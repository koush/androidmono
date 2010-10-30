namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnimationDrawable : android.graphics.drawable.DrawableContainer, java.lang.Runnable, Animatable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AnimationDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run5837;
		public virtual void run()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._run5837.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._run5837 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "run", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._run5837);
		}
		internal static global::MonoJavaBridge.MethodId _start5838;
		public virtual void start()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._start5838.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._start5838 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "start", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._start5838);
		}
		internal static global::MonoJavaBridge.MethodId _stop5839;
		public virtual void stop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._stop5839.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._stop5839 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "stop", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._stop5839);
		}
		internal static global::MonoJavaBridge.MethodId _inflate5840;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._inflate5840.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._inflate5840 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._inflate5840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleSelf5841;
		public override void unscheduleSelf(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._unscheduleSelf5841.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._unscheduleSelf5841 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "unscheduleSelf", "(Ljava/lang/Runnable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._unscheduleSelf5841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void unscheduleSelf(global::java.lang.RunnableDelegate arg0)
		{
			unscheduleSelf((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible5842;
		public override bool setVisible(bool arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._setVisible5842.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._setVisible5842 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "setVisible", "(ZZ)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._setVisible5842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _mutate5843;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._mutate5843.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._mutate5843 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._mutate5843) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getDuration5844;
		public virtual int getDuration(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._getDuration5844.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._getDuration5844 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "getDuration", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._getDuration5844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isRunning5845;
		public virtual bool isRunning()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._isRunning5845.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._isRunning5845 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "isRunning", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._isRunning5845);
		}
		public new int NumberOfFrames
		{
			get
			{
				return getNumberOfFrames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumberOfFrames5846;
		public virtual int getNumberOfFrames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._getNumberOfFrames5846.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._getNumberOfFrames5846 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "getNumberOfFrames", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._getNumberOfFrames5846);
		}
		internal static global::MonoJavaBridge.MethodId _getFrame5847;
		public virtual global::android.graphics.drawable.Drawable getFrame(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._getFrame5847.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._getFrame5847 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "getFrame", "(I)Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._getFrame5847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _isOneShot5848;
		public virtual bool isOneShot()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._isOneShot5848.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._isOneShot5848 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "isOneShot", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._isOneShot5848);
		}
		public new bool OneShot
		{
			set
			{
				setOneShot(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOneShot5849;
		public virtual void setOneShot(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._setOneShot5849.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._setOneShot5849 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "setOneShot", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._setOneShot5849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addFrame5850;
		public virtual void addFrame(android.graphics.drawable.Drawable arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._addFrame5850.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._addFrame5850 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "addFrame", "(Landroid/graphics/drawable/Drawable;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._addFrame5850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AnimationDrawable5851;
		public AnimationDrawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.AnimationDrawable._AnimationDrawable5851.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.AnimationDrawable._AnimationDrawable5851 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._AnimationDrawable5851);
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
