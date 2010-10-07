namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HeterogeneousExpandableList 
	{
		int getChildType(int arg0, int arg1);
		int getChildTypeCount();
		int getGroupType(int arg0);
		int getGroupTypeCount();
	}

	public partial class HeterogeneousExpandableList_
	{
		public static global::java.lang.Class _class
		{
			get { return __HeterogeneousExpandableList.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HeterogeneousExpandableList : java.lang.Object, HeterogeneousExpandableList
	{
		internal static global::java.lang.Class staticClass;
		static __HeterogeneousExpandableList()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.__HeterogeneousExpandableList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.__HeterogeneousExpandableList(@__env);
			}
		}
		internal __HeterogeneousExpandableList(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildType11012;
		 int android.widget.HeterogeneousExpandableList.getChildType(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__HeterogeneousExpandableList._getChildType11012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__HeterogeneousExpandableList.staticClass, global::android.widget.__HeterogeneousExpandableList._getChildType11012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildTypeCount11013;
		 int android.widget.HeterogeneousExpandableList.getChildTypeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__HeterogeneousExpandableList._getChildTypeCount11013);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__HeterogeneousExpandableList.staticClass, global::android.widget.__HeterogeneousExpandableList._getChildTypeCount11013);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroupType11014;
		 int android.widget.HeterogeneousExpandableList.getGroupType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__HeterogeneousExpandableList._getGroupType11014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__HeterogeneousExpandableList.staticClass, global::android.widget.__HeterogeneousExpandableList._getGroupType11014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroupTypeCount11015;
		 int android.widget.HeterogeneousExpandableList.getGroupTypeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__HeterogeneousExpandableList._getGroupTypeCount11015);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__HeterogeneousExpandableList.staticClass, global::android.widget.__HeterogeneousExpandableList._getGroupTypeCount11015);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.__HeterogeneousExpandableList.staticClass = @__class;
			global::android.widget.__HeterogeneousExpandableList._getChildType11012 = @__env.GetMethodID(global::android.widget.__HeterogeneousExpandableList.staticClass, "android.widget.HeterogeneousExpandableList.getChildType", "(II)I");
			global::android.widget.__HeterogeneousExpandableList._getChildTypeCount11013 = @__env.GetMethodID(global::android.widget.__HeterogeneousExpandableList.staticClass, "android.widget.HeterogeneousExpandableList.getChildTypeCount", "()I");
			global::android.widget.__HeterogeneousExpandableList._getGroupType11014 = @__env.GetMethodID(global::android.widget.__HeterogeneousExpandableList.staticClass, "android.widget.HeterogeneousExpandableList.getGroupType", "(I)I");
			global::android.widget.__HeterogeneousExpandableList._getGroupTypeCount11015 = @__env.GetMethodID(global::android.widget.__HeterogeneousExpandableList.staticClass, "android.widget.HeterogeneousExpandableList.getGroupTypeCount", "()I");
		}
	}
}
