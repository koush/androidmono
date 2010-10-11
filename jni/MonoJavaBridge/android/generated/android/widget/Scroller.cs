namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Scroller : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Scroller()
		{
			InitJNI();
		}
		protected Scroller(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDuration11875;
		public virtual int getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getDuration11875);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getDuration11875);
		}
		internal static global::MonoJavaBridge.MethodId _isFinished11876;
		public virtual bool isFinished() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Scroller._isFinished11876);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._isFinished11876);
		}
		internal static global::MonoJavaBridge.MethodId _forceFinished11877;
		public virtual void forceFinished(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._forceFinished11877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._forceFinished11877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrX11878;
		public virtual int getCurrX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getCurrX11878);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getCurrX11878);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrY11879;
		public virtual int getCurrY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getCurrY11879);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getCurrY11879);
		}
		internal static global::MonoJavaBridge.MethodId _getStartX11880;
		public virtual int getStartX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getStartX11880);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getStartX11880);
		}
		internal static global::MonoJavaBridge.MethodId _getStartY11881;
		public virtual int getStartY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getStartY11881);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getStartY11881);
		}
		internal static global::MonoJavaBridge.MethodId _getFinalX11882;
		public virtual int getFinalX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getFinalX11882);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getFinalX11882);
		}
		internal static global::MonoJavaBridge.MethodId _getFinalY11883;
		public virtual int getFinalY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getFinalY11883);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getFinalY11883);
		}
		internal static global::MonoJavaBridge.MethodId _computeScrollOffset11884;
		public virtual bool computeScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Scroller._computeScrollOffset11884);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._computeScrollOffset11884);
		}
		internal static global::MonoJavaBridge.MethodId _startScroll11885;
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._startScroll11885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._startScroll11885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _startScroll11886;
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._startScroll11886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._startScroll11886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _fling11887;
		public virtual void fling(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._fling11887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._fling11887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _abortAnimation11888;
		public virtual void abortAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._abortAnimation11888);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._abortAnimation11888);
		}
		internal static global::MonoJavaBridge.MethodId _extendDuration11889;
		public virtual void extendDuration(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._extendDuration11889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._extendDuration11889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _timePassed11890;
		public virtual int timePassed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._timePassed11890);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._timePassed11890);
		}
		internal static global::MonoJavaBridge.MethodId _setFinalX11891;
		public virtual void setFinalX(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._setFinalX11891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._setFinalX11891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFinalY11892;
		public virtual void setFinalY(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._setFinalY11892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._setFinalY11892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Scroller11893;
		public Scroller(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._Scroller11893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scroller11894;
		public Scroller(android.content.Context arg0, android.view.animation.Interpolator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._Scroller11894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Scroller.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Scroller"));
			global::android.widget.Scroller._getDuration11875 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getDuration", "()I");
			global::android.widget.Scroller._isFinished11876 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "isFinished", "()Z");
			global::android.widget.Scroller._forceFinished11877 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "forceFinished", "(Z)V");
			global::android.widget.Scroller._getCurrX11878 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getCurrX", "()I");
			global::android.widget.Scroller._getCurrY11879 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getCurrY", "()I");
			global::android.widget.Scroller._getStartX11880 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getStartX", "()I");
			global::android.widget.Scroller._getStartY11881 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getStartY", "()I");
			global::android.widget.Scroller._getFinalX11882 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getFinalX", "()I");
			global::android.widget.Scroller._getFinalY11883 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getFinalY", "()I");
			global::android.widget.Scroller._computeScrollOffset11884 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "computeScrollOffset", "()Z");
			global::android.widget.Scroller._startScroll11885 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "startScroll", "(IIII)V");
			global::android.widget.Scroller._startScroll11886 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "startScroll", "(IIIII)V");
			global::android.widget.Scroller._fling11887 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "fling", "(IIIIIIII)V");
			global::android.widget.Scroller._abortAnimation11888 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "abortAnimation", "()V");
			global::android.widget.Scroller._extendDuration11889 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "extendDuration", "(I)V");
			global::android.widget.Scroller._timePassed11890 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "timePassed", "()I");
			global::android.widget.Scroller._setFinalX11891 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "setFinalX", "(I)V");
			global::android.widget.Scroller._setFinalY11892 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "setFinalY", "(I)V");
			global::android.widget.Scroller._Scroller11893 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Scroller._Scroller11894 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;)V");
		}
	}
}
