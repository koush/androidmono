namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ColorMatrixColorFilter : android.graphics.ColorFilter
	{
		internal new static global::java.lang.Class staticClass;
		static ColorMatrixColorFilter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.ColorMatrixColorFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.ColorMatrixColorFilter(@__env);
			}
		}
		protected ColorMatrixColorFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _ColorMatrixColorFilter3123;
		public ColorMatrixColorFilter(android.graphics.ColorMatrix arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.ColorMatrixColorFilter.staticClass, global::android.graphics.ColorMatrixColorFilter._ColorMatrixColorFilter3123, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ColorMatrixColorFilter3124;
		public ColorMatrixColorFilter(float[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.ColorMatrixColorFilter.staticClass, global::android.graphics.ColorMatrixColorFilter._ColorMatrixColorFilter3124, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.ColorMatrixColorFilter.staticClass = @__class;
			global::android.graphics.ColorMatrixColorFilter._ColorMatrixColorFilter3123 = @__env.GetMethodID(global::android.graphics.ColorMatrixColorFilter.staticClass, "<init>", "(Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrixColorFilter._ColorMatrixColorFilter3124 = @__env.GetMethodID(global::android.graphics.ColorMatrixColorFilter.staticClass, "<init>", "([F)V");
		}
	}
}
