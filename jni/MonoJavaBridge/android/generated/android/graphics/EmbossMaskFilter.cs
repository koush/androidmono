namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class EmbossMaskFilter : android.graphics.MaskFilter
	{
		internal new static global::java.lang.Class staticClass;
		static EmbossMaskFilter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.EmbossMaskFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.EmbossMaskFilter(@__env);
			}
		}
		protected EmbossMaskFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _EmbossMaskFilter3132;
		public EmbossMaskFilter(float[] arg0, float arg1, float arg2, float arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.EmbossMaskFilter.staticClass, global::android.graphics.EmbossMaskFilter._EmbossMaskFilter3132, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.EmbossMaskFilter.staticClass = @__class;
			global::android.graphics.EmbossMaskFilter._EmbossMaskFilter3132 = @__env.GetMethodID(global::android.graphics.EmbossMaskFilter.staticClass, "<init>", "([FFFF)V");
		}
	}
}
