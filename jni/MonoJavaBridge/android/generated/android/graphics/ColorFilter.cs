namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ColorFilter : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ColorFilter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.ColorFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.ColorFilter(@__env);
			}
		}
		protected ColorFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _ColorFilter3107;
		public ColorFilter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.ColorFilter.staticClass, global::android.graphics.ColorFilter._ColorFilter3107, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.ColorFilter.staticClass = @__class;
			global::android.graphics.ColorFilter._ColorFilter3107 = @__env.GetMethodID(global::android.graphics.ColorFilter.staticClass, "<init>", "()V");
		}
	}
}
