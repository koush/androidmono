namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathMeasure : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PathMeasure()
		{
			InitJNI();
		}
		protected PathMeasure(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize3593;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.PathMeasure._finalize3593);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._finalize3593);
		}
		internal static global::MonoJavaBridge.MethodId _getLength3594;
		public virtual float getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.PathMeasure._getLength3594);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._getLength3594);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed3595;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.PathMeasure._isClosed3595);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._isClosed3595);
		}
		internal static global::MonoJavaBridge.MethodId _getMatrix3596;
		public virtual bool getMatrix(float arg0, android.graphics.Matrix arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.PathMeasure._getMatrix3596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._getMatrix3596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setPath3597;
		public virtual void setPath(android.graphics.Path arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.PathMeasure._setPath3597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._setPath3597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPosTan3598;
		public virtual bool getPosTan(float arg0, float[] arg1, float[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.PathMeasure._getPosTan3598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._getPosTan3598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getSegment3599;
		public virtual bool getSegment(float arg0, float arg1, android.graphics.Path arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.PathMeasure._getSegment3599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._getSegment3599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _nextContour3600;
		public virtual bool nextContour() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.PathMeasure._nextContour3600);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._nextContour3600);
		}
		internal static global::MonoJavaBridge.MethodId _PathMeasure3601;
		public PathMeasure()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._PathMeasure3601);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PathMeasure3602;
		public PathMeasure(android.graphics.Path arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PathMeasure.staticClass, global::android.graphics.PathMeasure._PathMeasure3602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PathMeasure.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PathMeasure"));
			global::android.graphics.PathMeasure._finalize3593 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "finalize", "()V");
			global::android.graphics.PathMeasure._getLength3594 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "getLength", "()F");
			global::android.graphics.PathMeasure._isClosed3595 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "isClosed", "()Z");
			global::android.graphics.PathMeasure._getMatrix3596 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "getMatrix", "(FLandroid/graphics/Matrix;I)Z");
			global::android.graphics.PathMeasure._setPath3597 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "setPath", "(Landroid/graphics/Path;Z)V");
			global::android.graphics.PathMeasure._getPosTan3598 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "getPosTan", "(F[F[F)Z");
			global::android.graphics.PathMeasure._getSegment3599 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "getSegment", "(FFLandroid/graphics/Path;Z)Z");
			global::android.graphics.PathMeasure._nextContour3600 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "nextContour", "()Z");
			global::android.graphics.PathMeasure._PathMeasure3601 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "<init>", "()V");
			global::android.graphics.PathMeasure._PathMeasure3602 = @__env.GetMethodIDNoThrow(global::android.graphics.PathMeasure.staticClass, "<init>", "(Landroid/graphics/Path;Z)V");
		}
	}
}
