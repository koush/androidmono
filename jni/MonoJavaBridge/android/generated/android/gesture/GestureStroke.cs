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
		internal static global::MonoJavaBridge.MethodId _clone4986;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke._clone4986)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._clone4986)) as java.lang.Object;
		}
		public new global::android.graphics.Path Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath4987;
		public virtual global::android.graphics.Path getPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke._getPath4987)) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._getPath4987)) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _toPath4988;
		public virtual global::android.graphics.Path toPath(float arg0, float arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke._toPath4988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._toPath4988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _clearPath4989;
		public virtual void clearPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStroke._clearPath4989);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._clearPath4989);
		}
		internal static global::MonoJavaBridge.MethodId _computeOrientedBoundingBox4990;
		public virtual global::android.gesture.OrientedBoundingBox computeOrientedBoundingBox()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke._computeOrientedBoundingBox4990)) as android.gesture.OrientedBoundingBox;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._computeOrientedBoundingBox4990)) as android.gesture.OrientedBoundingBox;
		}
		internal static global::MonoJavaBridge.MethodId _GestureStroke4991;
		public GestureStroke(java.util.ArrayList arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._GestureStroke4991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _boundingBox4992;
		public global::android.graphics.RectF boundingBox
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _boundingBox4992)) as android.graphics.RectF;
			}
		}
		internal static global::MonoJavaBridge.FieldId _length4993;
		public float length
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _length4993);
			}
		}
		internal static global::MonoJavaBridge.FieldId _points4994;
		public float[] points
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.GetObjectField(this.JvmHandle, _points4994)) as float[];
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureStroke.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureStroke"));
			global::android.gesture.GestureStroke._clone4986 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.gesture.GestureStroke._getPath4987 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "getPath", "()Landroid/graphics/Path;");
			global::android.gesture.GestureStroke._toPath4988 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "toPath", "(FFI)Landroid/graphics/Path;");
			global::android.gesture.GestureStroke._clearPath4989 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "clearPath", "()V");
			global::android.gesture.GestureStroke._computeOrientedBoundingBox4990 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "computeOrientedBoundingBox", "()Landroid/gesture/OrientedBoundingBox;");
			global::android.gesture.GestureStroke._GestureStroke4991 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "<init>", "(Ljava/util/ArrayList;)V");
			global::android.gesture.GestureStroke._boundingBox4992 = @__env.GetFieldIDNoThrow(global::android.gesture.GestureStroke.staticClass, "boundingBox", "Landroid/graphics/RectF;");
			global::android.gesture.GestureStroke._length4993 = @__env.GetFieldIDNoThrow(global::android.gesture.GestureStroke.staticClass, "length", "F");
			global::android.gesture.GestureStroke._points4994 = @__env.GetFieldIDNoThrow(global::android.gesture.GestureStroke.staticClass, "points", "[F");
		}
	}
}
