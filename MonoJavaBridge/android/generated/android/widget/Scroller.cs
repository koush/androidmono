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
		internal static global::MonoJavaBridge.MethodId _getDuration17713;
		public virtual int getDuration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getDuration17713);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getDuration17713);
		}
		internal static global::MonoJavaBridge.MethodId _isFinished17714;
		public virtual bool isFinished()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Scroller._isFinished17714);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._isFinished17714);
		}
		internal static global::MonoJavaBridge.MethodId _forceFinished17715;
		public virtual void forceFinished(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._forceFinished17715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._forceFinished17715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrX
		{
			get
			{
				return getCurrX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrX17716;
		public virtual int getCurrX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getCurrX17716);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getCurrX17716);
		}
		public new int CurrY
		{
			get
			{
				return getCurrY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrY17717;
		public virtual int getCurrY()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getCurrY17717);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getCurrY17717);
		}
		public new int StartX
		{
			get
			{
				return getStartX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStartX17718;
		public virtual int getStartX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getStartX17718);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getStartX17718);
		}
		public new int StartY
		{
			get
			{
				return getStartY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStartY17719;
		public virtual int getStartY()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getStartY17719);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getStartY17719);
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
		internal static global::MonoJavaBridge.MethodId _getFinalX17720;
		public virtual int getFinalX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getFinalX17720);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getFinalX17720);
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
		internal static global::MonoJavaBridge.MethodId _getFinalY17721;
		public virtual int getFinalY()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getFinalY17721);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getFinalY17721);
		}
		internal static global::MonoJavaBridge.MethodId _computeScrollOffset17722;
		public virtual bool computeScrollOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Scroller._computeScrollOffset17722);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._computeScrollOffset17722);
		}
		internal static global::MonoJavaBridge.MethodId _startScroll17723;
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._startScroll17723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._startScroll17723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _startScroll17724;
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._startScroll17724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._startScroll17724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _fling17725;
		public virtual void fling(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._fling17725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._fling17725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _abortAnimation17726;
		public virtual void abortAnimation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._abortAnimation17726);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._abortAnimation17726);
		}
		internal static global::MonoJavaBridge.MethodId _extendDuration17727;
		public virtual void extendDuration(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._extendDuration17727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._extendDuration17727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _timePassed17728;
		public virtual int timePassed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._timePassed17728);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._timePassed17728);
		}
		internal static global::MonoJavaBridge.MethodId _setFinalX17729;
		public virtual void setFinalX(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._setFinalX17729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._setFinalX17729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFinalY17730;
		public virtual void setFinalY(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._setFinalY17730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._setFinalY17730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Scroller17731;
		public Scroller(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._Scroller17731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scroller17732;
		public Scroller(android.content.Context arg0, android.view.animation.Interpolator arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._Scroller17732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Scroller()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Scroller.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Scroller"));
			global::android.widget.Scroller._getDuration17713 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getDuration", "()I");
			global::android.widget.Scroller._isFinished17714 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "isFinished", "()Z");
			global::android.widget.Scroller._forceFinished17715 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "forceFinished", "(Z)V");
			global::android.widget.Scroller._getCurrX17716 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getCurrX", "()I");
			global::android.widget.Scroller._getCurrY17717 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getCurrY", "()I");
			global::android.widget.Scroller._getStartX17718 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getStartX", "()I");
			global::android.widget.Scroller._getStartY17719 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getStartY", "()I");
			global::android.widget.Scroller._getFinalX17720 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getFinalX", "()I");
			global::android.widget.Scroller._getFinalY17721 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getFinalY", "()I");
			global::android.widget.Scroller._computeScrollOffset17722 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "computeScrollOffset", "()Z");
			global::android.widget.Scroller._startScroll17723 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "startScroll", "(IIII)V");
			global::android.widget.Scroller._startScroll17724 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "startScroll", "(IIIII)V");
			global::android.widget.Scroller._fling17725 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "fling", "(IIIIIIII)V");
			global::android.widget.Scroller._abortAnimation17726 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "abortAnimation", "()V");
			global::android.widget.Scroller._extendDuration17727 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "extendDuration", "(I)V");
			global::android.widget.Scroller._timePassed17728 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "timePassed", "()I");
			global::android.widget.Scroller._setFinalX17729 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "setFinalX", "(I)V");
			global::android.widget.Scroller._setFinalY17730 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "setFinalY", "(I)V");
			global::android.widget.Scroller._Scroller17731 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Scroller._Scroller17732 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
