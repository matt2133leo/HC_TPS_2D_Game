using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    /*數學運算子宣告區*/
    public int a = 10, b = 3 , c = 5 , d = 11;
    public int score = 50;
    /*比較運算子宣告區*/
    public int num1 = 1000, num2 = 500;
    /*邏輯運算子宣告區*/
    public bool boolA = true, boolB = false;
    public int hp = 100;
    public int prop = 10;

    public bool test_bool;

    private void Start()
    {
        #region 數學運算子區域 
        // 數學運算子
        print(a + b); // 加 13
        print(a - b); // 減 7
        print(a * b); // 乘 30
        print(a / b); // 除 3
        print(a % b); // 餘數1  10 / 3 = 3.......1 兩數相除剩下的數字

        // 遞增 ++ 、遞減 --
        print(c++); //先輸出再執行遞增,先輸出c 再執行 ++
        print(++d); //先執行再遞增,先執行++ 再輸出d

                            //指定運算: 等號右邊會先運算再傳給左邊 ,亦即 先執行score + 10 再傳回 score
                            // "=" 指定的意思
                            // 適用所有數學運算
        print(score);       //運算前的計算
        score = score + 10; // 簡寫法：score += 10;
        print(score);       //顯示運算後的計算
        #endregion


        #region 比較運算子
        //比較運算子 (結果為布林值 True / False)
        print(num1 > num2);  //大於
        print(num1 < num2);  //小於
        print(num1 >= num2); //大於等於
        print(num1 <= num2); //小於等於
        print(num1 == num2); //等於
        print(num1 != num2); //不等於
        #endregion

        #region 邏輯運算子
        //邏輯運算子
        // 並且 && 鍵盤按法 : Shift + 7 
        print(boolA && boolB); // 只要有一個 false 結果為 false
        print(true && true);   // 結果 true
        print(true && false);  // 結果 false
        print(false && true);  // 結果 false
        print(false && false); // 結果 false

        // 或者 || 鍵盤按法 : Shift + \
        print(boolA || boolB); // 只要有一個 true 結果為 true
        print(true || true);   // 結果 true
        print(true || false);  // 結果 true
        print(false || true);  // 結果 true
        print(false || false); // 結果 false

        // 過關條件：HP > 50　並且 道具 > 7
        print(hp > 50 && prop > 7); //結果 true

        //相反 !
        print(!true);  // false
        print(!false);  // true

        test_bool = false || true; //true
        print(test_bool);  //true
        print(!test_bool); //false
        #endregion

    }
}
