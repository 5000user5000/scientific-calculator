using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //變數宣告
        double firstnum, secondnum = 1; //存取運算子上一個和下一個數字,先預設1,因為四則運算(先乘除後加減)時會用到
        string operation = ""; //存運算子
        string operation_old = "";//存舊的運算子,應付四則運算
        double memory_num = 0; // M系列按鍵所需要的變數,存累計結果
        bool num_stay = true;//當按下運算子時,螢幕上的數字不會消失,直到按下新數字為止
        bool sec_used = false;//也就是確認secondnum在此次運算是否有存取過值,用於四則運算



        private void btnC_click(object sender, EventArgs e)//C是特殊鍵,另外安排功能,負責清除螢幕顯示數字和恢復預設
        {
            //恢復預設的值
            label1.Text = "0"; //歸零
            operation = "";//運算子也是
            num_stay = true;
            sec_used = false;
            operation_old = "";
            secondnum = 1;
        }

        private void show_num(object sender, EventArgs e)//數字和"."按下的功能
        {
            Button b = (Button)sender; //擁有此方法的按紐統稱b,當按到某按紐時,會回傳那個按鈕的資料(如上面的text),這樣就不用每一個按鈕都設一個click
            if (label1.Text == "0" && b.Text != ".") label1.Text = ""; //如果開頭是0的話,先把它弄掉,因為可不會產生01這樣的數字(也就是0不會是首位,除非小數),另一個條件就是針對0開頭的小數
            if (b.Text == ".")//如果按下"."這個按紐,會執行下面的程式,確認螢幕的數字是否已經有".",如果已經有,那就不會重複
            {
                if (!label1.Text.Contains(".")) label1.Text = label1.Text + b.Text;//如果還沒含有".",就會加入".",反之就不會
            }
            else //當上面的if把前面的數字0清空,這裡就會執行(因為前面的if就會失效)
            {
                if(!num_stay)//當前面按下運算子,一開始的數字不會消失,當按下新數字時,舊數字就會消失
                {
                    label1.Text = "";//清空前面的數字,讓道給新數字
                    num_stay = true;//並把num_stay轉成true,這樣按新數字時,才不會一直消失
                }
                if (b.Text == "π") label1.Text = Convert.ToString( Math.PI );  //當按下Pi的情況
                else label1.Text = label1.Text + b.Text; //直接在後面加數字,還有如果前面的num_stay因為是false清空螢幕,後來同步更新成true,這裡的else會一起執行.(也就是說按新數字,舊數消失,新數會出現)

            }
        }

        private void operational_function(object sender, EventArgs e) //和special function不同處是這裡的運算子是需要兩個數字去計算,special function只要一個數字就好
        {
            Button b = (Button)sender;
            //第一次計算
            if (operation == "") firstnum = Double.Parse(label1.Text);//把數字轉成double,和convert.todouble 一樣.
            //多次計算(在按等於前,按了複數個運算子),有很多if,但這也沒辦法,要應付多次運算來有四則運算
            else if (operation == "+" || operation == "-")
            {
                if (b.Text == "+" || b.Text == "-")//如果前面已經按了加減,卻沒有按等於,就會啟動這裡來做連續計算
                {
                    if (operation == "+") firstnum += Double.Parse(label1.Text); //因為都是+-,優先度相同,所以只要把這個數字和之前存取的數字運算,都存存在firstnum
                    if (operation == "-") firstnum -= Double.Parse(label1.Text);
                }
                if (b.Text == "*" || b.Text == "/") //如果前面是+-,而後來按下優先度更高的*/,就先給secondnum賦值
                {
                    secondnum = Double.Parse(label1.Text);
                    sec_used = true;//表示secondnum已被動過,非預設
                    operation_old = operation;//因為先乘除後加減,當這次遇到乘除時,運算子會在下面的code更新成乘除,這樣在做等於運算時,會忽略之前的加減,所以要把加減存到另一個位置
                }

            }
            else if (operation == "*" || operation == "/")//如果前面已經按了乘除,卻沒有按等於,就會啟動這裡來做連續計算
            {
                if (b.Text == "+" || b.Text == "-") //按了乘除後,沒按等於,又按+-
                {
                    if (operation == "*") firstnum *= Double.Parse(label1.Text); //因為*/優先度高,先把之前存的數值處理
                    if (operation == "/") firstnum /= Double.Parse(label1.Text);
                }
                if (b.Text == "*" || b.Text == "/") //如果前面是+-,而後來按下優先度更高的*/,就先給secondnum賦值
                {
                    if (sec_used)//如果secondnum有被用過,表示*/的數字是存在secondnum
                    {
                        if (operation == "*") secondnum *= Double.Parse(label1.Text);
                        if (operation == "/") secondnum /= Double.Parse(label1.Text);
                    }
                    else //如secondnum沒被用過,表示*/的數字是存在firstnum
                    {
                        if (operation == "*") firstnum *= Double.Parse(label1.Text);
                        if (operation == "/") firstnum /= Double.Parse(label1.Text);

                    }

                }

            }
            else
            {
                btnEQ_click(null, null);//如果是Mod之類非+-*/的運算子,直接呼叫等於的方法,因為非+-*/的運算子優先度最高,遇到優先度低的直接先行計算
                firstnum = Double.Parse( label1.Text );//計算完後,把firstnum更新,不然就會用舊的第一數字去計算
            }
            
   
            operation = b.Text; //先把運算子存起來,等按到等於鍵時,依據此運算子來選擇計算方法
            num_stay = false; //關掉num_stay,這樣按下新數字時,舊數字就消失,不會還連著新數字
            //label1.Text = "";  原本是採取每按下運算子,舊數字就消失,這樣方便程式存取第一和二的數字,但通常應該要在按新數字前都不該讓舊數字去掉,所以添加了num_stay
            

        }

        private void btnDel_click(object sender, EventArgs e) //當按下刪除鍵
        {
            if (label1.Text.Length > 0) //如果螢幕數字長度>0,就會刪除最右邊的數字
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1); //刪除最右邊的數字
            }
            if(label1.Text == "")//如果沒有數字了,或是個位數被上面的if刪掉了,自動補成0
            {
                label1.Text = "0"; //顯示0
            }
        }

        private void btnPM_click(object sender, EventArgs e) //當按下正負鍵,p->positive,n->negative
        {
            if(label1.Text.Contains("-"))//如果(開頭)有負號,就把他去掉,相當於把負轉正
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
            else //如果沒有負號,就加上負號
            {
                label1.Text = "-" + label1.Text;//把負號加在前面. 因為都是string type,所以不用特別轉換
            }
        }

        private void btnEQ_click(object sender, EventArgs e) //當按下等於鍵,使用存取的運算子,來進行計算
        {
            if(operation=="*" && secondnum != 1) secondnum *= double.Parse(label1.Text);//把第二個數字(新數字)存起來,用乘法是為了應付累乘,如果是第一次,secondnum =1,如果是之前是多次運算還沒按下等於,就可以把先前存的統計於此
            else if (operation == "/" && secondnum!=1) secondnum /= double.Parse(label1.Text);//secondnum!=1當作是他已被用過的情況,應付連除.如果沒被用過的話,走else直接更新secondnum
            else secondnum = double.Parse(label1.Text);//如果運算子是加減,就直接指定secondnum就好

            if (operation_old != "") operation = operation_old;//乘除已經在上面的if-else做過了,如果有存過舊的運算子,直接換上來,完成最後的運算(優先度較低)
            switch (operation) //根據運算子來決定哪種運算方法,用switch在這樣多種假設情況的case比if-else簡單方便
            { 
                
                case "+":
                    label1.Text = Convert.ToString(firstnum + secondnum);
                    break; //一定要加,不然會出錯
                case "-":
                    label1.Text = Convert.ToString(firstnum - secondnum);
                    break;
                case "*":
                    label1.Text = Convert.ToString(firstnum * secondnum);
                    break;
                case "/":
                    label1.Text = Convert.ToString(firstnum / secondnum);
                    break;
                case "x^y":
                    label1.Text = Convert.ToString( Math.Pow(firstnum ,secondnum) );  //使用Math類別的pow,前面是底數,後面是次方
                    break;
                case "y√": //開y根號
                    label1.Text = Convert.ToString(Math.Pow(firstnum, 1/secondnum));//把次方 取倒數即可
                    break;
                case "Mod":
                    label1.Text = Convert.ToString(firstnum % secondnum); //餘數
                    break;
                default: //當沒有符合任一條件就離開,不加似乎也可以,但是通常是會加的樣子
                    break;

            }
            operation = "";//把運算子歸零,為了達成四則運算的效果,因為我設計的四則運算必須存取之前的運算子,按下等於後,得清除,不然會影響後面的運算
            secondnum = 1;//恢復預設
            sec_used = false;//恢復預設
            operation_old = "";//恢復預設

        }

        private void btnMs_click(object sender, EventArgs e) //表示M系列被按下時的方法
        {
            Button b = (Button)sender;

            switch (b.Text)
            {
                case "M+": //記憶當前數字,加入累計
                    memory_num += Convert.ToDouble(label1.Text);
                    break;
                case "M-": //記憶當前數字,減入累計
                    memory_num -= Convert.ToDouble(label1.Text);
                    break;
                case "MC": //把累計清0
                    memory_num = 0;
                    break;
                case "MR": //把累計叫出
                    label1.Text = Convert.ToString(memory_num);
                    break;
                case "MS": //用當前數字取代累計
                    memory_num = Convert.ToDouble(label1.Text);
                    break;
                default:  //預設,如果都沒符合者,直接跳出此switch
                    break;
            }
        }

        private void special_function(object sender, EventArgs e) //特殊運算符,只需要一個數字即可運算,且不用按等於就會出現運算結果
        {
            Button b = (Button)sender;
            switch(b.Text)
            {
                
                case "cos":
                    double num = Convert.ToDouble(label1.Text); //先宣告變數,似乎不能放在case外,就放此了,把螢幕的數字存于此.目的是方便之後取值時,只要寫num,不用把Convert.ToDouble(label1.Text)整個寫出
                    //計算角度需要看是deg 還是 rad or grad 
                    if (rbRAD.Checked) //rbRAF->radioButton RAD在被選取時啟動
                    {
                        
                        label1.Text = Convert.ToString(Math.Cos(num));//一開始Math的算法應該是rad

                    }
                    else if (rbDEG.Checked) // deg
                    {

                        double ang = num * Math.PI / 180; //把 rad轉成deg , 1rad = pi/180 deg
                        label1.Text = Convert.ToString(Math.Cos(ang));
                    }
                    else if(rbGRAD.Checked) //grad
                    {
                        double ang = num /400* 2*Math.PI ; //把 rad轉成grad , 2pi rad = 400 grad -> 1 grad =  2pi/400
                        label1.Text = Convert.ToString(Math.Cos(ang));
                    }
                    
                    break;
                case "sin":
                    num = Convert.ToDouble(label1.Text);
                    if (rbRAD.Checked) //這裡的radioButton的程式就是直接複製原本的在修改,sin cos tan上都有做
                    {

                        label1.Text = Convert.ToString(Math.Sin(num));//一開始Math的算法應該是rad

                    }
                    else if (rbDEG.Checked)
                    {

                        double ang = num * Math.PI / 180; //把 rad轉成deg , 1rad = pi/180 deg
                        label1.Text = Convert.ToString(Math.Sin(ang));
                    }
                    else if (rbGRAD.Checked)
                    {
                        double ang = num / 400 * 2 * Math.PI; //把 rad轉成grad , 2pi rad = 400 grad
                        label1.Text = Convert.ToString(Math.Sin(ang));
                    }
                    break;
                case "tan":
                    num = Convert.ToDouble(label1.Text);
                    if (rbRAD.Checked) //計算角度需要看是deg 還是 rad
                    {

                        label1.Text = Convert.ToString(Math.Tan(num));//一開始Math的算法應該是rad

                    }
                    else if (rbDEG.Checked)
                    {

                        double ang = num * Math.PI / 180; //把 rad轉成deg , 1rad = pi/180 deg
                        label1.Text = Convert.ToString(Math.Tan(ang));
                    }
                    else if (rbGRAD.Checked)
                    {
                        double ang = num / 400 * 2 * Math.PI; //把 rad轉成grad , 2pi rad = 400 grad
                        label1.Text = Convert.ToString(Math.Tan(ang));
                    }
                    break;
                case "x^2":
                    num = Convert.ToDouble(label1.Text);
                    label1.Text = Convert.ToString(Math.Pow(num,2));
                    break;
                
                case "n!":
                    num = Convert.ToInt32(label1.Text);
                    int factorial=1; //階乘
                    for (int i = 1; i <  num+1; i++) //< =似乎無法用就改用< num+1 ; 因為math似乎沒有現有的,只好自己生一個計算階乘(從1乘到n)的函數
                    {
                        factorial = factorial * i; //factorial累乘1~n

                    }
                    label1.Text = Convert.ToString(factorial);
                    break;
                case "Exp":
                    num = Convert.ToDouble(label1.Text);
                    label1.Text = Convert.ToString(Math.Exp(num));
                    break;
                case "log":
                    num = Convert.ToDouble(label1.Text);
                    label1.Text = Convert.ToString(Math.Log10(num));
                    break;
                case "ln":
                    num = Convert.ToDouble(label1.Text);
                    label1.Text = Convert.ToString(Math.Log(num));
                    break;
                case "√":
                    num = Convert.ToDouble(label1.Text);
                    label1.Text = Convert.ToString(Math.Sqrt(num));
                    break;
                case "sinh":
                    num = Convert.ToDouble(label1.Text);
                    label1.Text = Convert.ToString(Math.Sinh(num));
                    break;
                case "cosh":
                    num = Convert.ToDouble(label1.Text);
                    label1.Text = Convert.ToString(Math.Cosh(num));
                    break;
                case "tanh":
                    num = Convert.ToDouble(label1.Text);
                    label1.Text = Convert.ToString(Math.Tanh(num));
                    break;
                case "1/x":
                    num = Convert.ToDouble(label1.Text);
                    label1.Text = Convert.ToString(1/num);
                    break;
                    

                default:
                    break;


            }
        }

        
        

    }
}
