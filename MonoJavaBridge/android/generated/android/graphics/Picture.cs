namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Picture : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Picture(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Picture.staticClass, "finalize", "()V", ref global::android.graphics.Picture._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Picture.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.Picture._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.graphics.Picture createFromStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Picture._m2.native == global::System.IntPtr.Zero)
				global::android.graphics.Picture._m2 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Picture.staticClass, "createFromStream", "(Ljava/io/InputStream;)Landroid/graphics/Picture;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Picture.staticClass, global::android.graphics.Picture._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Picture;
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Picture.staticClass, "getWidth", "()I", ref global::android.graphics.Picture._m3);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Picture.staticClass, "getHeight", "()I", ref global::android.graphics.Picture._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.graphics.Canvas beginRecording(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Picture.staticClass, "beginRecording", "(II)Landroid/graphics/Canvas;", ref global::android.graphics.Picture._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.graphics.Canvas;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void endRecording()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Picture.staticClass, "endRecording", "()V", ref global::android.graphics.Picture._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void writeToStream(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Picture.staticClass, "writeToStream", "(Ljava/io/OutputStream;)V", ref global::android.graphics.Picture._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public Picture() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Picture._m8.native == global::System.IntPtr.Zero)
				global::android.graphics.Picture._m8 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Picture.staticClass, global::android.graphics.Picture._m8);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public Picture(android.graphics.Picture arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Picture._m9.native == global::System.IntPtr.Zero)
				global::android.graphics.Picture._m9 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "<init>", "(Landroid/graphics/Picture;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Picture.staticClass, global::android.graphics.Picture._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Picture()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Picture.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Picture"));
		}
		internal static void InitJNI()
		{
		}
	}
}
