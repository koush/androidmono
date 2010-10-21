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
		public new int Duration
		{
			get
			{
				return getDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDuration17606;
		public virtual int getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getDuration17606);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getDuration17606);
		}
		internal static global::MonoJavaBridge.MethodId _isFinished17607;
		public virtual bool isFinished() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Scroller._isFinished17607);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._isFinished17607);
		}
		internal static global::MonoJavaBridge.MethodId _forceFinished17608;
		public virtual void forceFinished(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._forceFinished17608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._forceFinished17608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrX
		{
			get
			{
				return getCurrX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrX17609;
		public virtual int getCurrX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getCurrX17609);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getCurrX17609);
		}
		public new int CurrY
		{
			get
			{
				return getCurrY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrY17610;
		public virtual int getCurrY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getCurrY17610);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getCurrY17610);
		}
		public new int StartX
		{
			get
			{
				return getStartX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStartX17611;
		public virtual int getStartX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getStartX17611);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getStartX17611);
		}
		public new int StartY
		{
			get
			{
				return getStartY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStartY17612;
		public virtual int getStartY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getStartY17612);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getStartY17612);
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
		internal static global::MonoJavaBridge.MethodId _getFinalX17613;
		public virtual int getFinalX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getFinalX17613);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getFinalX17613);
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
		internal static global::MonoJavaBridge.MethodId _getFinalY17614;
		public virtual int getFinalY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getFinalY17614);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getFinalY17614);
		}
		internal static global::MonoJavaBridge.MethodId _computeScrollOffset17615;
		public virtual bool computeScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Scroller._computeScrollOffset17615);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._computeScrollOffset17615);
		}
		internal static global::MonoJavaBridge.MethodId _startScroll17616;
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._startScroll17616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._startScroll17616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _startScroll17617;
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._startScroll17617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._startScroll17617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _fling17618;
		public virtual void fling(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._fling17618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._fling17618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _abortAnimation17619;
		public virtual void abortAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._abortAnimation17619);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._abortAnimation17619);
		}
		internal static global::MonoJavaBridge.MethodId _extendDuration17620;
		public virtual void extendDuration(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._extendDuration17620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._extendDuration17620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _timePassed17621;
		public virtual int timePassed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._timePassed17621);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._timePassed17621);
		}
		internal static global::MonoJavaBridge.MethodId _setFinalX17622;
		public virtual void setFinalX(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._setFinalX17622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._setFinalX17622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFinalY17623;
		public virtual void setFinalY(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._setFinalY17623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._setFinalY17623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Scroller17624;
		public Scroller(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._Scroller17624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scroller17625;
		public Scroller(android.content.Context arg0, android.view.animation.Interpolator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._Scroller17625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Scroller.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Scroller"));
			global::android.widget.Scroller._getDuration17606 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getDuration", "()I");
			global::android.widget.Scroller._isFinished17607 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "isFinished", "()Z");
			global::android.widget.Scroller._forceFinished17608 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "forceFinished", "(Z)V");
			global::android.widget.Scroller._getCurrX17609 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getCurrX", "()I");
			global::android.widget.Scroller._getCurrY17610 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getCurrY", "()I");
			global::android.widget.Scroller._getStartX17611 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getStartX", "()I");
			global::android.widget.Scroller._getStartY17612 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getStartY", "()I");
			global::android.widget.Scroller._getFinalX17613 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getFinalX", "()I");
			global::android.widget.Scroller._getFinalY17614 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getFinalY", "()I");
			global::android.widget.Scroller._computeScrollOffset17615 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "computeScrollOffset", "()Z");
			global::android.widget.Scroller._startScroll17616 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "startScroll", "(IIII)V");
			global::android.widget.Scroller._startScroll17617 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "startScroll", "(IIIII)V");
			global::android.widget.Scroller._fling17618 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "fling", "(IIIIIIII)V");
			global::android.widget.Scroller._abortAnimation17619 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "abortAnimation", "()V");
			global::android.widget.Scroller._extendDuration17620 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "extendDuration", "(I)V");
			global::android.widget.Scroller._timePassed17621 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "timePassed", "()I");
			global::android.widget.Scroller._setFinalX17622 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "setFinalX", "(I)V");
			global::android.widget.Scroller._setFinalY17623 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "setFinalY", "(I)V");
			global::android.widget.Scroller._Scroller17624 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Scroller._Scroller17625 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;)V");
		}
	}
}
