namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PorterDuffColorFilter : android.graphics.ColorFilter
	{
		internal new static global::java.lang.Class staticClass;
		static PorterDuffColorFilter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.PorterDuffColorFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.PorterDuffColorFilter(@__env);
			}
		}
		protected PorterDuffColorFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _PorterDuffColorFilter3277;
		public PorterDuffColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.PorterDuffColorFilter.staticClass, global::android.graphics.PorterDuffColorFilter._PorterDuffColorFilter3277, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.PorterDuffColorFilter.staticClass = @__class;
			global::android.graphics.PorterDuffColorFilter._PorterDuffColorFilter3277 = @__env.GetMethodID(global::android.graphics.PorterDuffColorFilter.staticClass, "<init>", "(ILandroid/graphics/PorterDuff$Mode;)V");
		}
	}
}
