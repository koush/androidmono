namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class WebBackForwardList : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static WebBackForwardList()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebBackForwardList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.WebBackForwardList(@__env);
			}
		}
		protected WebBackForwardList(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone10043;
		protected virtual global::android.webkit.WebBackForwardList clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebBackForwardList._clone10043));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._clone10043));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSize10044;
		public virtual int getSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebBackForwardList._getSize10044);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getSize10044);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentItem10045;
		public virtual global::android.webkit.WebHistoryItem getCurrentItem() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebBackForwardList._getCurrentItem10045));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getCurrentItem10045));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentIndex10046;
		public virtual int getCurrentIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebBackForwardList._getCurrentIndex10046);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getCurrentIndex10046);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemAtIndex10047;
		public virtual global::android.webkit.WebHistoryItem getItemAtIndex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebBackForwardList._getItemAtIndex10047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getItemAtIndex10047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.WebBackForwardList.staticClass = @__class;
			global::android.webkit.WebBackForwardList._clone10043 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "clone", "()Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebBackForwardList._getSize10044 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "getSize", "()I");
			global::android.webkit.WebBackForwardList._getCurrentItem10045 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "getCurrentItem", "()Landroid/webkit/WebHistoryItem;");
			global::android.webkit.WebBackForwardList._getCurrentIndex10046 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "getCurrentIndex", "()I");
			global::android.webkit.WebBackForwardList._getItemAtIndex10047 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "getItemAtIndex", "(I)Landroid/webkit/WebHistoryItem;");
		}
	}
}
