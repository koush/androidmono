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
		internal static global::net.sf.jni4net.jni.MethodId _getDuration10776; 
		public virtual int getDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getDuration10776); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getDuration10776); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFinished10777; 
		public virtual bool isFinished() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.Scroller._isFinished10777); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._isFinished10777); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _forceFinished10778; 
		public virtual void forceFinished(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.Scroller._forceFinished10778, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._forceFinished10778, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrX10779; 
		public virtual int getCurrX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getCurrX10779); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getCurrX10779); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrY10780; 
		public virtual int getCurrY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getCurrY10780); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getCurrY10780); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartX10781; 
		public virtual int getStartX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getStartX10781); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getStartX10781); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartY10782; 
		public virtual int getStartY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getStartY10782); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getStartY10782); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFinalX10783; 
		public virtual int getFinalX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getFinalX10783); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getFinalX10783); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFinalY10784; 
		public virtual int getFinalY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.Scroller._getFinalY10784); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._getFinalY10784); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScrollOffset10785; 
		public virtual bool computeScrollOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.Scroller._computeScrollOffset10785); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._computeScrollOffset10785); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startScroll10786; 
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.Scroller._startScroll10786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._startScroll10786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startScroll10787; 
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.Scroller._startScroll10787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._startScroll10787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fling10788; 
		public virtual void fling(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.Scroller._fling10788, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._fling10788, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _abortAnimation10789; 
		public virtual void abortAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.Scroller._abortAnimation10789); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._abortAnimation10789); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extendDuration10790; 
		public virtual void extendDuration(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.Scroller._extendDuration10790, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._extendDuration10790, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _timePassed10791; 
		public virtual int timePassed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.Scroller._timePassed10791); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._timePassed10791); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFinalX10792; 
		public virtual void setFinalX(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.Scroller._setFinalX10792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._setFinalX10792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFinalY10793; 
		public virtual void setFinalY(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.Scroller._setFinalY10793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Scroller.staticClass, global::android.widget.Scroller._setFinalY10793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Scroller10794; 
		public Scroller(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._Scroller10794, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Scroller10795; 
		public Scroller(android.content.Context arg0, android.view.animation.Interpolator arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Scroller.staticClass, global::android.widget.Scroller._Scroller10795, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.Scroller.staticClass = @__class; 
			global::android.widget.Scroller._getDuration10776 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getDuration", "()I"); 
			global::android.widget.Scroller._isFinished10777 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "isFinished", "()Z"); 
			global::android.widget.Scroller._forceFinished10778 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "forceFinished", "(Z)V"); 
			global::android.widget.Scroller._getCurrX10779 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getCurrX", "()I"); 
			global::android.widget.Scroller._getCurrY10780 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getCurrY", "()I"); 
			global::android.widget.Scroller._getStartX10781 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getStartX", "()I"); 
			global::android.widget.Scroller._getStartY10782 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getStartY", "()I"); 
			global::android.widget.Scroller._getFinalX10783 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getFinalX", "()I"); 
			global::android.widget.Scroller._getFinalY10784 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getFinalY", "()I"); 
			global::android.widget.Scroller._computeScrollOffset10785 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "computeScrollOffset", "()Z"); 
			global::android.widget.Scroller._startScroll10786 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "startScroll", "(IIII)V"); 
			global::android.widget.Scroller._startScroll10787 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "startScroll", "(IIIII)V"); 
			global::android.widget.Scroller._fling10788 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "fling", "(IIIIIIII)V"); 
			global::android.widget.Scroller._abortAnimation10789 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "abortAnimation", "()V"); 
			global::android.widget.Scroller._extendDuration10790 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "extendDuration", "(I)V"); 
			global::android.widget.Scroller._timePassed10791 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "timePassed", "()I"); 
			global::android.widget.Scroller._setFinalX10792 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "setFinalX", "(I)V"); 
			global::android.widget.Scroller._setFinalY10793 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "setFinalY", "(I)V"); 
			global::android.widget.Scroller._Scroller10794 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.Scroller._Scroller10795 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;)V"); 
		} 
	} 
} 
