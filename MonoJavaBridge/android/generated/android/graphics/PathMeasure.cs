namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathMeasure : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PathMeasure(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize5573;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._finalize5573);
		}
		public new float Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength5574;
		public virtual float getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._getLength5574);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed5575;
		public virtual bool isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._isClosed5575);
		}
		internal static global::MonoJavaBridge.MethodId _getMatrix5576;
		public virtual bool getMatrix(float arg0, android.graphics.Matrix arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._getMatrix5576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setPath5577;
		public virtual void setPath(android.graphics.Path arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._setPath5577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPosTan5578;
		public virtual bool getPosTan(float arg0, float[] arg1, float[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._getPosTan5578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getSegment5579;
		public virtual bool getSegment(float arg0, float arg1, android.graphics.Path arg2, bool arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._getSegment5579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _nextContour5580;
		public virtual bool nextContour()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._nextContour5580);
		}
		internal static global::MonoJavaBridge.MethodId _PathMeasure5581;
		public PathMeasure() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._PathMeasure5581);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PathMeasure5582;
		public PathMeasure(android.graphics.Path arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._PathMeasure5582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::android.graphics.PathMeasure._finalize5573 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "finalize", "()V");
			global::android.graphics.PathMeasure._getLength5574 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "getLength", "()F");
			global::android.graphics.PathMeasure._isClosed5575 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "isClosed", "()Z");
			global::android.graphics.PathMeasure._getMatrix5576 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "getMatrix", "(FLandroid/graphics/Matrix;I)Z");
			global::android.graphics.PathMeasure._setPath5577 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "setPath", "(Landroid/graphics/Path;Z)V");
			global::android.graphics.PathMeasure._getPosTan5578 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "getPosTan", "(F[F[F)Z");
			global::android.graphics.PathMeasure._getSegment5579 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "getSegment", "(FFLandroid/graphics/Path;Z)Z");
			global::android.graphics.PathMeasure._nextContour5580 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "nextContour", "()Z");
			global::android.graphics.PathMeasure._PathMeasure5581 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "<init>", "()V");
			global::android.graphics.PathMeasure._PathMeasure5582 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "<init>", "(Landroid/graphics/Path;Z)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
