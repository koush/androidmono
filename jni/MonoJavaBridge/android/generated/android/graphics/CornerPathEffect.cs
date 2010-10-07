namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CornerPathEffect : android.graphics.PathEffect
	{
		internal new static global::java.lang.Class staticClass;
		static CornerPathEffect()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.CornerPathEffect), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.CornerPathEffect(@__env);
			}
		}
		protected CornerPathEffect(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _CornerPathEffect3128;
		public CornerPathEffect(float arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.CornerPathEffect.staticClass, global::android.graphics.CornerPathEffect._CornerPathEffect3128, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.CornerPathEffect.staticClass = @__class;
			global::android.graphics.CornerPathEffect._CornerPathEffect3128 = @__env.GetMethodID(global::android.graphics.CornerPathEffect.staticClass, "<init>", "(F)V");
		}
	}
}
