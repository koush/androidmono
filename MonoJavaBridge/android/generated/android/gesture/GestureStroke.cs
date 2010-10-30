namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GestureStroke : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GestureStroke(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureStroke.staticClass, "clone", "()Ljava/lang/Object;", ref global::android.gesture.GestureStroke._m0) as java.lang.Object;
		}
		public new global::android.graphics.Path Path
		{
			get
			{
				return getPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.graphics.Path getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureStroke.staticClass, "getPath", "()Landroid/graphics/Path;", ref global::android.gesture.GestureStroke._m1) as android.graphics.Path;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.graphics.Path toPath(float arg0, float arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureStroke.staticClass, "toPath", "(FFI)Landroid/graphics/Path;", ref global::android.gesture.GestureStroke._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.graphics.Path;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void clearPath()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStroke.staticClass, "clearPath", "()V", ref global::android.gesture.GestureStroke._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.gesture.OrientedBoundingBox computeOrientedBoundingBox()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureStroke.staticClass, "computeOrientedBoundingBox", "()Landroid/gesture/OrientedBoundingBox;", ref global::android.gesture.GestureStroke._m4) as android.gesture.OrientedBoundingBox;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public GestureStroke(java.util.ArrayList arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureStroke._m5.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureStroke._m5 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStroke.staticClass, "<init>", "(Ljava/util/ArrayList;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureStroke.staticClass, global::android.gesture.GestureStroke._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _boundingBox2224;
		public global::android.graphics.RectF boundingBox
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _boundingBox2224)) as android.graphics.RectF;
			}
		}
		internal static global::MonoJavaBridge.FieldId _length2225;
		public float length
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _length2225);
			}
		}
		internal static global::MonoJavaBridge.FieldId _points2226;
		public float[] points
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.GetObjectField(this.JvmHandle, _points2226)) as float[];
			}
		}
		static GestureStroke()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureStroke.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureStroke"));
			global::android.gesture.GestureStroke._boundingBox2224 = @__env.GetFieldIDNoThrow(global::android.gesture.GestureStroke.staticClass, "boundingBox", "Landroid/graphics/RectF;");
			global::android.gesture.GestureStroke._length2225 = @__env.GetFieldIDNoThrow(global::android.gesture.GestureStroke.staticClass, "length", "F");
			global::android.gesture.GestureStroke._points2226 = @__env.GetFieldIDNoThrow(global::android.gesture.GestureStroke.staticClass, "points", "[F");
		}
		internal static void InitJNI()
		{
		}
	}
}
