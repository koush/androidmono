namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Scroller : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Scroller(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Duration
		{
			get
			{
				return getDuration();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getDuration()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Scroller.staticClass, "getDuration", "()I", ref global::android.widget.Scroller._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool isFinished()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Scroller.staticClass, "isFinished", "()Z", ref global::android.widget.Scroller._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void forceFinished(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Scroller.staticClass, "forceFinished", "(Z)V", ref global::android.widget.Scroller._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrX
		{
			get
			{
				return getCurrX();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getCurrX()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Scroller.staticClass, "getCurrX", "()I", ref global::android.widget.Scroller._m3);
		}
		public new int CurrY
		{
			get
			{
				return getCurrY();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getCurrY()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Scroller.staticClass, "getCurrY", "()I", ref global::android.widget.Scroller._m4);
		}
		public new int StartX
		{
			get
			{
				return getStartX();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getStartX()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Scroller.staticClass, "getStartX", "()I", ref global::android.widget.Scroller._m5);
		}
		public new int StartY
		{
			get
			{
				return getStartY();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getStartY()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Scroller.staticClass, "getStartY", "()I", ref global::android.widget.Scroller._m6);
		}
		public new int FinalX
		{
			get
			{
				return getFinalX();
			}
			set
			{
				setFinalX(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getFinalX()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Scroller.staticClass, "getFinalX", "()I", ref global::android.widget.Scroller._m7);
		}
		public new int FinalY
		{
			get
			{
				return getFinalY();
			}
			set
			{
				setFinalY(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getFinalY()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Scroller.staticClass, "getFinalY", "()I", ref global::android.widget.Scroller._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool computeScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Scroller.staticClass, "computeScrollOffset", "()Z", ref global::android.widget.Scroller._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Scroller.staticClass, "startScroll", "(IIII)V", ref global::android.widget.Scroller._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Scroller.staticClass, "startScroll", "(IIIII)V", ref global::android.widget.Scroller._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void fling(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Scroller.staticClass, "fling", "(IIIIIIII)V", ref global::android.widget.Scroller._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void abortAnimation()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Scroller.staticClass, "abortAnimation", "()V", ref global::android.widget.Scroller._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void extendDuration(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Scroller.staticClass, "extendDuration", "(I)V", ref global::android.widget.Scroller._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int timePassed()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Scroller.staticClass, "timePassed", "()I", ref global::android.widget.Scroller._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setFinalX(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Scroller.staticClass, "setFinalX", "(I)V", ref global::android.widget.Scroller._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setFinalY(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Scroller.staticClass, "setFinalY", "(I)V", ref global::android.widget.Scroller._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public Scroller(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Scroller._m18.native == global::System.IntPtr.Zero)
				global::android.widget.Scroller._m18 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public Scroller(android.content.Context arg0, android.view.animation.Interpolator arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Scroller._m19.native == global::System.IntPtr.Zero)
				global::android.widget.Scroller._m19 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Scroller()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Scroller.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Scroller"));
		}
	}
}
