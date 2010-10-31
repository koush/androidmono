namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Gesture : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Gesture(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.Gesture.staticClass, "clone", "()Ljava/lang/Object;", ref global::android.gesture.Gesture._m0) as java.lang.Object;
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
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.gesture.Gesture.staticClass, "getLength", "()F", ref global::android.gesture.Gesture._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.Gesture.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.gesture.Gesture._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.Gesture.staticClass, "describeContents", "()I", ref global::android.gesture.Gesture._m3);
		}
		public new global::java.util.ArrayList Strokes
		{
			get
			{
				return getStrokes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.util.ArrayList getStrokes()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.Gesture.staticClass, "getStrokes", "()Ljava/util/ArrayList;", ref global::android.gesture.Gesture._m4) as java.util.ArrayList;
		}
		public new int StrokesCount
		{
			get
			{
				return getStrokesCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getStrokesCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.Gesture.staticClass, "getStrokesCount", "()I", ref global::android.gesture.Gesture._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void addStroke(android.gesture.GestureStroke arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.Gesture.staticClass, "addStroke", "(Landroid/gesture/GestureStroke;)V", ref global::android.gesture.Gesture._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.RectF BoundingBox
		{
			get
			{
				return getBoundingBox();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.graphics.RectF getBoundingBox()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.Gesture.staticClass, "getBoundingBox", "()Landroid/graphics/RectF;", ref global::android.gesture.Gesture._m7) as android.graphics.RectF;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.graphics.Path toPath(android.graphics.Path arg0, int arg1, int arg2, int arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.Gesture.staticClass, "toPath", "(Landroid/graphics/Path;IIII)Landroid/graphics/Path;", ref global::android.gesture.Gesture._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.graphics.Path;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.graphics.Path toPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.Gesture.staticClass, "toPath", "()Landroid/graphics/Path;", ref global::android.gesture.Gesture._m9) as android.graphics.Path;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.graphics.Path toPath(android.graphics.Path arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.Gesture.staticClass, "toPath", "(Landroid/graphics/Path;)Landroid/graphics/Path;", ref global::android.gesture.Gesture._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Path;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::android.graphics.Path toPath(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.Gesture.staticClass, "toPath", "(IIII)Landroid/graphics/Path;", ref global::android.gesture.Gesture._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.graphics.Path;
		}
		public new long ID
		{
			get
			{
				return getID();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual long getID()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.gesture.Gesture.staticClass, "getID", "()J", ref global::android.gesture.Gesture._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.graphics.Bitmap toBitmap(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.gesture.Gesture.staticClass, "toBitmap", "(IIII)Landroid/graphics/Bitmap;", ref global::android.gesture.Gesture._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::android.graphics.Bitmap toBitmap(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.gesture.Gesture.staticClass, "toBitmap", "(IIIII)Landroid/graphics/Bitmap;", ref global::android.gesture.Gesture._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public Gesture() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.Gesture._m15.native == global::System.IntPtr.Zero)
				global::android.gesture.Gesture._m15 = @__env.GetMethodIDNoThrow(global::android.gesture.Gesture.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.Gesture.staticClass, global::android.gesture.Gesture._m15);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2212;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.gesture.Gesture.staticClass, _CREATOR2212)) as android.os.Parcelable_Creator;
			}
		}
		static Gesture()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.Gesture.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/Gesture"));
			global::android.gesture.Gesture._CREATOR2212 = @__env.GetStaticFieldIDNoThrow(global::android.gesture.Gesture.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
