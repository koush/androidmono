namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GestureStroke : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GestureStroke()
		{
			InitJNI();
		}
		protected GestureStroke(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone3049;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke._clone3049)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._clone3049)) as java.lang.Object;
		}
		public new global::android.graphics.Path Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath3050;
		public virtual global::android.graphics.Path getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke._getPath3050)) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._getPath3050)) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _toPath3051;
		public virtual global::android.graphics.Path toPath(float arg0, float arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke._toPath3051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._toPath3051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _clearPath3052;
		public virtual void clearPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStroke._clearPath3052);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._clearPath3052);
		}
		internal static global::MonoJavaBridge.MethodId _computeOrientedBoundingBox3053;
		public virtual global::android.gesture.OrientedBoundingBox computeOrientedBoundingBox() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke._computeOrientedBoundingBox3053)) as android.gesture.OrientedBoundingBox;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._computeOrientedBoundingBox3053)) as android.gesture.OrientedBoundingBox;
		}
		internal static global::MonoJavaBridge.MethodId _GestureStroke3054;
		public GestureStroke(java.util.ArrayList arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._GestureStroke3054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _boundingBox3055;
		public global::android.graphics.RectF boundingBox
		{
			get
			{
				return default(global::android.graphics.RectF);
			}
		}
		internal static global::MonoJavaBridge.FieldId _length3056;
		public float length
		{
			get
			{
				return default(float);
			}
		}
		internal static global::MonoJavaBridge.FieldId _points3057;
		public float[] points
		{
			get
			{
				return default(float[]);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureStroke.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureStroke"));
			global::android.gesture.GestureStroke._clone3049 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.gesture.GestureStroke._getPath3050 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "getPath", "()Landroid/graphics/Path;");
			global::android.gesture.GestureStroke._toPath3051 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "toPath", "(FFI)Landroid/graphics/Path;");
			global::android.gesture.GestureStroke._clearPath3052 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "clearPath", "()V");
			global::android.gesture.GestureStroke._computeOrientedBoundingBox3053 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "computeOrientedBoundingBox", "()Landroid/gesture/OrientedBoundingBox;");
			global::android.gesture.GestureStroke._GestureStroke3054 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "<init>", "(Ljava/util/ArrayList;)V");
		}
	}
}
