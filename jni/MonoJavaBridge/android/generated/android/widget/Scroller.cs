namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Scroller : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Scroller()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.Scroller), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.Scroller(@__env);
			}
		}
		protected Scroller(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDuration11489;
		public virtual int getDuration() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getDuration11489);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getDuration11489);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFinished11490;
		public virtual bool isFinished() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Scroller._isFinished11490);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._isFinished11490);
		}
		internal static global::net.sf.jni4net.jni.MethodId _forceFinished11491;
		public virtual void forceFinished(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Scroller._forceFinished11491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._forceFinished11491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrX11492;
		public virtual int getCurrX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getCurrX11492);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getCurrX11492);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrY11493;
		public virtual int getCurrY() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getCurrY11493);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getCurrY11493);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStartX11494;
		public virtual int getStartX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getStartX11494);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getStartX11494);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStartY11495;
		public virtual int getStartY() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getStartY11495);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getStartY11495);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFinalX11496;
		public virtual int getFinalX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getFinalX11496);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getFinalX11496);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFinalY11497;
		public virtual int getFinalY() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getFinalY11497);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getFinalY11497);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeScrollOffset11498;
		public virtual bool computeScrollOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Scroller._computeScrollOffset11498);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._computeScrollOffset11498);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startScroll11499;
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Scroller._startScroll11499, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._startScroll11499, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startScroll11500;
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Scroller._startScroll11500, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._startScroll11500, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fling11501;
		public virtual void fling(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Scroller._fling11501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._fling11501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _abortAnimation11502;
		public virtual void abortAnimation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Scroller._abortAnimation11502);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._abortAnimation11502);
		}
		internal static global::net.sf.jni4net.jni.MethodId _extendDuration11503;
		public virtual void extendDuration(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Scroller._extendDuration11503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._extendDuration11503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _timePassed11504;
		public virtual int timePassed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Scroller._timePassed11504);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._timePassed11504);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFinalX11505;
		public virtual void setFinalX(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Scroller._setFinalX11505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._setFinalX11505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFinalY11506;
		public virtual void setFinalY(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Scroller._setFinalY11506, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._setFinalY11506, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Scroller11507;
		public Scroller(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._Scroller11507, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Scroller11508;
		public Scroller(android.content.Context arg0, android.view.animation.Interpolator arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._Scroller11508, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.Scroller.staticClass = @__class;
			global::android.widget.Scroller._getDuration11489 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getDuration", "()I");
			global::android.widget.Scroller._isFinished11490 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "isFinished", "()Z");
			global::android.widget.Scroller._forceFinished11491 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "forceFinished", "(Z)V");
			global::android.widget.Scroller._getCurrX11492 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getCurrX", "()I");
			global::android.widget.Scroller._getCurrY11493 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getCurrY", "()I");
			global::android.widget.Scroller._getStartX11494 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getStartX", "()I");
			global::android.widget.Scroller._getStartY11495 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getStartY", "()I");
			global::android.widget.Scroller._getFinalX11496 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getFinalX", "()I");
			global::android.widget.Scroller._getFinalY11497 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getFinalY", "()I");
			global::android.widget.Scroller._computeScrollOffset11498 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "computeScrollOffset", "()Z");
			global::android.widget.Scroller._startScroll11499 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "startScroll", "(IIII)V");
			global::android.widget.Scroller._startScroll11500 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "startScroll", "(IIIII)V");
			global::android.widget.Scroller._fling11501 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "fling", "(IIIIIIII)V");
			global::android.widget.Scroller._abortAnimation11502 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "abortAnimation", "()V");
			global::android.widget.Scroller._extendDuration11503 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "extendDuration", "(I)V");
			global::android.widget.Scroller._timePassed11504 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "timePassed", "()I");
			global::android.widget.Scroller._setFinalX11505 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "setFinalX", "(I)V");
			global::android.widget.Scroller._setFinalY11506 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "setFinalY", "(I)V");
			global::android.widget.Scroller._Scroller11507 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Scroller._Scroller11508 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;)V");
		}
	}
}
