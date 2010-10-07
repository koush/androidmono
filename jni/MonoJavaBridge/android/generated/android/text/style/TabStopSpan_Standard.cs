namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TabStopSpan_Standard : java.lang.Object, TabStopSpan
	{
		internal static global::java.lang.Class staticClass;
		static TabStopSpan_Standard()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.TabStopSpan_Standard), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.TabStopSpan_Standard(@__env);
			}
		}
		protected TabStopSpan_Standard(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTabStop8064;
		public virtual int getTabStop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.TabStopSpan_Standard._getTabStop8064);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.TabStopSpan_Standard.staticClass, global::android.text.style.TabStopSpan_Standard._getTabStop8064);
		}
		internal static global::net.sf.jni4net.jni.MethodId _TabStopSpan_Standard8065;
		public TabStopSpan_Standard(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.TabStopSpan_Standard.staticClass, global::android.text.style.TabStopSpan_Standard._TabStopSpan_Standard8065, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.TabStopSpan_Standard.staticClass = @__class;
			global::android.text.style.TabStopSpan_Standard._getTabStop8064 = @__env.GetMethodID(global::android.text.style.TabStopSpan_Standard.staticClass, "getTabStop", "()I");
			global::android.text.style.TabStopSpan_Standard._TabStopSpan_Standard8065 = @__env.GetMethodID(global::android.text.style.TabStopSpan_Standard.staticClass, "<init>", "(I)V");
		}
	}
}
