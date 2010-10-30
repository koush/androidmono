namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathMeasure : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PathMeasure(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PathMeasure.staticClass, "finalize", "()V", ref global::android.graphics.PathMeasure._m0);
		}
		public new float Length
		{
			get
			{
				return getLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual float getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.PathMeasure.staticClass, "getLength", "()F", ref global::android.graphics.PathMeasure._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.PathMeasure.staticClass, "isClosed", "()Z", ref global::android.graphics.PathMeasure._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool getMatrix(float arg0, android.graphics.Matrix arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.PathMeasure.staticClass, "getMatrix", "(FLandroid/graphics/Matrix;I)Z", ref global::android.graphics.PathMeasure._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setPath(android.graphics.Path arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PathMeasure.staticClass, "setPath", "(Landroid/graphics/Path;Z)V", ref global::android.graphics.PathMeasure._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool getPosTan(float arg0, float[] arg1, float[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.PathMeasure.staticClass, "getPosTan", "(F[F[F)Z", ref global::android.graphics.PathMeasure._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool getSegment(float arg0, float arg1, android.graphics.Path arg2, bool arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.PathMeasure.staticClass, "getSegment", "(FFLandroid/graphics/Path;Z)Z", ref global::android.graphics.PathMeasure._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool nextContour()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.PathMeasure.staticClass, "nextContour", "()Z", ref global::android.graphics.PathMeasure._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public PathMeasure() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PathMeasure._m8.native == global::System.IntPtr.Zero)
				global::android.graphics.PathMeasure._m8 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._m8);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public PathMeasure(android.graphics.Path arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PathMeasure._m9.native == global::System.IntPtr.Zero)
				global::android.graphics.PathMeasure._m9 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "<init>", "(Landroid/graphics/Path;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int POSITION_MATRIX_FLAG
		{
			get
			{
				return 1;
			}
		}
		public static int TANGENT_MATRIX_FLAG
		{
			get
			{
				return 2;
			}
		}
		static PathMeasure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PathMeasure.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PathMeasure"));
		}
		internal static void InitJNI()
		{
		}
	}
}
