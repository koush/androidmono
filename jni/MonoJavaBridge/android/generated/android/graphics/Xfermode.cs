namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Xfermode : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Xfermode()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Xfermode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.Xfermode(@__env);
			}
		}
		protected Xfermode(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _Xfermode3431;
		public Xfermode()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Xfermode.staticClass, global::android.graphics.Xfermode._Xfermode3431, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Xfermode.staticClass = @__class;
			global::android.graphics.Xfermode._Xfermode3431 = @__env.GetMethodID(global::android.graphics.Xfermode.staticClass, "<init>", "()V");
		}
	}
}
