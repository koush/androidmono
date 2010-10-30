namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnimationDrawable : android.graphics.drawable.DrawableContainer, java.lang.Runnable, Animatable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AnimationDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void run()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "run", "()V", ref global::android.graphics.drawable.AnimationDrawable._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "start", "()V", ref global::android.graphics.drawable.AnimationDrawable._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "stop", "()V", ref global::android.graphics.drawable.AnimationDrawable._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V", ref global::android.graphics.drawable.AnimationDrawable._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void unscheduleSelf(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "unscheduleSelf", "(Ljava/lang/Runnable;)V", ref global::android.graphics.drawable.AnimationDrawable._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void unscheduleSelf(global::java.lang.RunnableDelegate arg0)
		{
			unscheduleSelf((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool setVisible(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "setVisible", "(ZZ)Z", ref global::android.graphics.drawable.AnimationDrawable._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.AnimationDrawable._m6) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getDuration(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "getDuration", "(I)I", ref global::android.graphics.drawable.AnimationDrawable._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isRunning()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "isRunning", "()Z", ref global::android.graphics.drawable.AnimationDrawable._m8);
		}
		public new int NumberOfFrames
		{
			get
			{
				return getNumberOfFrames();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getNumberOfFrames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "getNumberOfFrames", "()I", ref global::android.graphics.drawable.AnimationDrawable._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.graphics.drawable.Drawable getFrame(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "getFrame", "(I)Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.AnimationDrawable._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool isOneShot()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "isOneShot", "()Z", ref global::android.graphics.drawable.AnimationDrawable._m11);
		}
		public new bool OneShot
		{
			set
			{
				setOneShot(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setOneShot(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "setOneShot", "(Z)V", ref global::android.graphics.drawable.AnimationDrawable._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void addFrame(android.graphics.drawable.Drawable arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, "addFrame", "(Landroid/graphics/drawable/Drawable;I)V", ref global::android.graphics.drawable.AnimationDrawable._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public AnimationDrawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._m14.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._m14 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._m14);
			Init(@__env, handle);
		}
		static AnimationDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.AnimationDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/AnimationDrawable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
