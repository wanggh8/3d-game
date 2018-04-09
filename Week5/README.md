#  操作与总结
## 参考 Fantasy Skybox FREE 构建自己的游戏场景
#### 双摄像机使用： 用来俯瞰整个地图，位于右下角

![1](https://img-blog.csdn.net/20180409210752712?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

 效果图

![2](https://img-blog.csdn.net/20180409210923908?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

#### SKY天空贴图，使用6张图贴成一个球状

![3](https://img-blog.csdn.net/20180409211100437?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

第一次贴图，效果还是不错的，主要是素材比较好

![4](https://img-blog.csdn.net/20180409211455823?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

#### 地形
比较高的五指山，和一些低的山脉。还有山中下路，以及平缓地区。种了很多树，还有草
![5](https://img-blog.csdn.net/20180409211644840?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)
![6](https://img-blog.csdn.net/20180409211849976?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

采用的素材
![7](https://img-blog.csdn.net/20180409211942381?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

#### 声音
采用了一个森林的音频文件，还是比较好听的，不足的是里面有鸟叫，我没做出来鸟。。。音频会在后面的演示链接里有。
![8](https://img-blog.csdn.net/20180409212118741?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

#### 第一人称视角

![9](https://img-blog.csdn.net/20180409212320728?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)
![10](https://img-blog.csdn.net/20180409212402455?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

游戏结果

![11](https://img-blog.csdn.net/20180409212547196?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3N5c3U5OTd3YW5n/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)


##  写一个简单的总结，总结游戏对象的使用
游戏对象是所有出现在场景中的实体，他们可以直接创建模型，也可以通过脚本，预设动态创建游戏对象。对于游戏对象，可以进行很多操作，以及添加其他组件。比如常用的transform对象，主要负责控制对象的位置，方向和大小。通过对游戏对象的操作，实现了游戏的一些基本操作。游戏对象还有一些负责场景和控制的，它们通常负责着对游戏规则和场景地图。

# 编程实践
牧师与魔鬼 动作分离版

演示视频


