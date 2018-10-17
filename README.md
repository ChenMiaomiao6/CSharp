# 实验二
## 老师您好，我是陈苗苗，本科是名艺术生，之前从未接触过这方面，所以会有很多不懂的地方，在通过百度、查看老师所发的资料，以及寻求同学帮助下，逐渐懂得如何操作。

## 实验目的：
- 使用Open XML SDK方法解析Word文件，提取出Word文件中的所有文字。文字按段落分组。

## 知识点：
- 使用vs2017中的nuget安装外部引用openxml：管理NuGet包、查询、搜索openxml下载安装。openxmlelement类表示一个基类派生自的office open xml文档中的所有元素。

< w:p > 表示一个段落

<<w:body>> 表示文章内容的开始；

</<w:body>> 表示文章内容的结束；


- 操作过程：

    先在vs2017上创建项目test2，编写代码
    
    1）先申明变量。 2）调出文档所在地址。  3）创建一个新的类。  4）将每行每个的数据都访问一次。  5）将对象打印出来显示。
    