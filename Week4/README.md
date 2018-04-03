# 简答并用程序验证
## 1.游戏对象运动的本质是什么？
游戏对象运动的本质就是在每一帧的画面中，游戏对象会发生相对位置或绝对位置的改变，或者是角度的旋转变化，即transform属性中的position跟rotation两个属性。
## 2.请用三种方法以上方法，实现物体的抛物线运动。（如，修改Transform属性，使用向量Vector3的方法…）
####1) 修改Transform属性
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int time = 1;
	//参数，随时间递增
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.down * Time.deltaTime * (time / 10);
		//上下方向匀加速运动
        this.transform.position += Vector3.left * Time.deltaTime * 5;
		//左右方向匀速运动
        time++;
    }
}
```
#### 2) 直接声明创建一个Vector3变量,将游戏对象原本的position属性与该向量相加
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    public int time = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = new Vector3(Time.deltaTime * 5, -Time.deltaTime * (time / 10), 0);
        //声明一个变化的向量Vector3
        this.transform.position += a;
        time++;
    }
}
```
#### 3) 直接声明创建一个Vector3变量,利用transform中的translate函数来进行改变position
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public int time = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = new Vector3(0, -Time.deltaTime * 5, Time.deltaTime * (time / 10));
        //声明一个变化的向量Vector3
        this.transform.Translate(a);
        time++;
    }
}
```

结果

![ans1](https://img-blog.csdn.net/20180402204044288?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

## 3.写一个程序，实现一个完整的太阳系， 其他星球围绕太阳的转速必须不一样，且不在一个法平面上。
对于月球的轨迹问题，采用建立空对象的方法
使用一个空对象作为地球的影子
将月球挂在这个空对象上
空对象与地球位置保持一致
对象的安排

![2](https://img-blog.csdn.net/20180403135932319?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

素材

![3](https://img-blog.csdn.net/20180403140024734?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

代码

![4](https://img-blog.csdn.net/20180403140102998?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

将Empty挂到空对象上，Sun挂到Sun对象上，Month挂到month对象上

sun.cs
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject.Find("Sun").transform.position = new Vector3(0, 0, 0);

        GameObject.Find("Mercury").transform.position = new Vector3(0, 0, 2);
        GameObject.Find("Venus").transform.position = new Vector3(2.8f, 0, 0);
        GameObject.Find("Earth").transform.position = new Vector3(0, 0, 3.5f);
        GameObject.Find("Mars").transform.position = new Vector3(0, 0, 4.2f);
        GameObject.Find("Jupiter").transform.position = new Vector3(0, 0, 4.8f);
        GameObject.Find("Saturn").transform.position = new Vector3(5.5f, 0, 0);
        GameObject.Find("Uranus").transform.position = new Vector3(6.5f, 0, 0);
        GameObject.Find("Neptune").transform.position = new Vector3(0, 7.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Earth").transform.Rotate(Vector3.up * Time.deltaTime * 500);
        GameObject.Find("Earth").transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0), 30 * Time.deltaTime);

        GameObject.Find("Mercury").transform.RotateAround(Vector3.zero, new Vector3(1, 1, 0), 25 * Time.deltaTime);
        GameObject.Find("Mercury").transform.Rotate(Vector3.up * Time.deltaTime * 500);

        GameObject.Find("Venus").transform.RotateAround(Vector3.zero, new Vector3(0, 1, 1), 20 * Time.deltaTime);
        GameObject.Find("Venus").transform.Rotate(Vector3.up * Time.deltaTime * 500);

        GameObject.Find("Mars").transform.RotateAround(Vector3.zero, new Vector3(2, 1, 0), 45 * Time.deltaTime);
        GameObject.Find("Mars").transform.Rotate(Vector3.up * Time.deltaTime * 500);

        GameObject.Find("Jupiter").transform.RotateAround(Vector3.zero, new Vector3(1, 2, 0), 35 * Time.deltaTime);
        GameObject.Find("Jupiter").transform.Rotate(Vector3.up * Time.deltaTime * 500);

        GameObject.Find("Saturn").transform.RotateAround(Vector3.zero, new Vector3(0, 1, 2), 40 * Time.deltaTime);
        GameObject.Find("Saturn").transform.Rotate(Vector3.up * Time.deltaTime * 500);

        GameObject.Find("Uranus").transform.RotateAround(Vector3.zero, new Vector3(0, 2, 1), 45 * Time.deltaTime);
        GameObject.Find("Uranus").transform.Rotate(Vector3.up * Time.deltaTime * 500);

        GameObject.Find("Neptune").transform.RotateAround(Vector3.zero, new Vector3(1, 0, 1), 50 * Time.deltaTime);
        GameObject.Find("Neptune").transform.Rotate(Vector3.up * Time.deltaTime * 500);

    }
}
```

Empty.cs
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empty : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        this.transform.position = new Vector3(0, 0, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0), 30 * Time.deltaTime);
    }
}

```

Month.cs
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.position = new Vector3(0, 0, 4.5f);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = this.transform.parent.position;

        this.transform.RotateAround(position, Vector3.up, 360 * Time.deltaTime);
	}
}

```

结果

![5](https://img-blog.csdn.net/20180403140438391?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)
视频展示


# 编程实践
### 阅读以下游戏脚本
Priests and Devils
Priests and Devils is a puzzle game in which you will help the Priests and Devils to cross the river within the time limit. There are 3 priests and 3 devils at one side of the river. They all want to get to the other side of this river, but there is only one boat and this boat can only carry two persons each time. And there must be one person steering the boat from one side to the other side. In the flash game, you can click on them to move them and click the go button to move the boat to the other direction. If the priests are out numbered by the devils on either side of the river, they get killed and the game is over. You can try it in many > ways. Keep all priests alive! Good luck!
### 程序需要满足的要求：
#### play the game ( http://www.flash-game.net/game/2535/priests-and-devils.html )
#### 列出游戏中提及的事物（Objects）
牧师、魔鬼、船、初始岸边、目的岸边
#### 用表格列出玩家动作表（规则表），注意，动作越少越好
动作 | 条件
- | :-: |
开船 | 
魔鬼下船 |
魔鬼上船 |
牧师下船 |
牧师上船 |

#### 请将游戏中对象做成预制
#### 在 GenGameObjects 中创建 长方形、正方形、球 及其色彩代表游戏中的对象。
#### 使用 C# 集合类型 有效组织对象
#### 整个游戏仅 主摄像机 和 一个 Empty 对象， 其他对象必须代码动态生成！！！ 。 整个游戏不许出现 Find 游戏对象， SendMessage 这类突破程序结构的 通讯耦合 语句。 违背本条准则，不给分
#### 请使用课件架构图编程，不接受非 MVC 结构程序
#### 注意细节，例如：船未靠岸，牧师与魔鬼上下船运动中，均不能接受用户事件！

