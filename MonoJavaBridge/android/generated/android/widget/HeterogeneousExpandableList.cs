namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.HeterogeneousExpandableList_))]
	public partial interface HeterogeneousExpandableList  : global::MonoJavaBridge.IJavaObject 
	{
		int getChildType(int arg0, int arg1);
		int getChildTypeCount();
		int getGroupType(int arg0);
		int getGroupTypeCount();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.HeterogeneousExpandableList))]
	internal sealed partial class HeterogeneousExpandableList_ : java.lang.Object, HeterogeneousExpandableList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HeterogeneousExpandableList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int android.widget.HeterogeneousExpandableList.getChildType(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeterogeneousExpandableList_.staticClass, "getChildType", "(II)I", ref global::android.widget.HeterogeneousExpandableList_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int android.widget.HeterogeneousExpandableList.getChildTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeterogeneousExpandableList_.staticClass, "getChildTypeCount", "()I", ref global::android.widget.HeterogeneousExpandableList_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int android.widget.HeterogeneousExpandableList.getGroupType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeterogeneousExpandableList_.staticClass, "getGroupType", "(I)I", ref global::android.widget.HeterogeneousExpandableList_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int android.widget.HeterogeneousExpandableList.getGroupTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeterogeneousExpandableList_.staticClass, "getGroupTypeCount", "()I", ref global::android.widget.HeterogeneousExpandableList_._m3);
		}
		static HeterogeneousExpandableList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.HeterogeneousExpandableList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/HeterogeneousExpandableList"));
		}
		internal static void InitJNI()
		{
		}
	}
}
