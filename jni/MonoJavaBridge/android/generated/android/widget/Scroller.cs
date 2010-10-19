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
		internal static global::MonoJavaBridge.MethodId _getDuration12421;
		public virtual int getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getDuration12421);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getDuration12421);
		}
		internal static global::MonoJavaBridge.MethodId _isFinished12422;
		public virtual bool isFinished() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Scroller._isFinished12422);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._isFinished12422);
		}
		internal static global::MonoJavaBridge.MethodId _forceFinished12423;
		public virtual void forceFinished(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._forceFinished12423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._forceFinished12423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrX
		{
			get
			{
				return getCurrX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrX12424;
		public virtual int getCurrX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getCurrX12424);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getCurrX12424);
		}
		public new int CurrY
		{
			get
			{
				return getCurrY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrY12425;
		public virtual int getCurrY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getCurrY12425);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getCurrY12425);
		}
		public new int StartX
		{
			get
			{
				return getStartX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStartX12426;
		public virtual int getStartX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getStartX12426);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getStartX12426);
		}
		public new int StartY
		{
			get
			{
				return getStartY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStartY12427;
		public virtual int getStartY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getStartY12427);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getStartY12427);
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
		internal static global::MonoJavaBridge.MethodId _getFinalX12428;
		public virtual int getFinalX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getFinalX12428);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getFinalX12428);
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
		internal static global::MonoJavaBridge.MethodId _getFinalY12429;
		public virtual int getFinalY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._getFinalY12429);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getFinalY12429);
		}
		internal static global::MonoJavaBridge.MethodId _computeScrollOffset12430;
		public virtual bool computeScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Scroller._computeScrollOffset12430);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._computeScrollOffset12430);
		}
		internal static global::MonoJavaBridge.MethodId _startScroll12431;
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._startScroll12431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._startScroll12431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _startScroll12432;
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._startScroll12432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._startScroll12432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _fling12433;
		public virtual void fling(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._fling12433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._fling12433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _abortAnimation12434;
		public virtual void abortAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._abortAnimation12434);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._abortAnimation12434);
		}
		internal static global::MonoJavaBridge.MethodId _extendDuration12435;
		public virtual void extendDuration(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._extendDuration12435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._extendDuration12435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _timePassed12436;
		public virtual int timePassed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Scroller._timePassed12436);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._timePassed12436);
		}
		internal static global::MonoJavaBridge.MethodId _setFinalX12437;
		public virtual void setFinalX(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._setFinalX12437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._setFinalX12437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFinalY12438;
		public virtual void setFinalY(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Scroller._setFinalY12438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._setFinalY12438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Scroller12439;
		public Scroller(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._Scroller12439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Scroller12440;
		public Scroller(android.content.Context arg0, android.view.animation.Interpolator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._Scroller12440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Scroller.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Scroller"));
			global::android.widget.Scroller._getDuration12421 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getDuration", "()I");
			global::android.widget.Scroller._isFinished12422 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "isFinished", "()Z");
			global::android.widget.Scroller._forceFinished12423 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "forceFinished", "(Z)V");
			global::android.widget.Scroller._getCurrX12424 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getCurrX", "()I");
			global::android.widget.Scroller._getCurrY12425 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getCurrY", "()I");
			global::android.widget.Scroller._getStartX12426 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getStartX", "()I");
			global::android.widget.Scroller._getStartY12427 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getStartY", "()I");
			global::android.widget.Scroller._getFinalX12428 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getFinalX", "()I");
			global::android.widget.Scroller._getFinalY12429 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "getFinalY", "()I");
			global::android.widget.Scroller._computeScrollOffset12430 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "computeScrollOffset", "()Z");
			global::android.widget.Scroller._startScroll12431 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "startScroll", "(IIII)V");
			global::android.widget.Scroller._startScroll12432 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "startScroll", "(IIIII)V");
			global::android.widget.Scroller._fling12433 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "fling", "(IIIIIIII)V");
			global::android.widget.Scroller._abortAnimation12434 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "abortAnimation", "()V");
			global::android.widget.Scroller._extendDuration12435 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "extendDuration", "(I)V");
			global::android.widget.Scroller._timePassed12436 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "timePassed", "()I");
			global::android.widget.Scroller._setFinalX12437 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "setFinalX", "(I)V");
			global::android.widget.Scroller._setFinalY12438 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "setFinalY", "(I)V");
			global::android.widget.Scroller._Scroller12439 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Scroller._Scroller12440 = @__env.GetMethodIDNoThrow(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;)V");
		}
	}
}
