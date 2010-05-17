namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Scroller : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Scroller() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.Scroller), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getDuration10000; 
		public virtual int getDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				return @__env.CallIntMethod(this, _getDuration10000); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Scroller.staticClass, _getDuration10000); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFinished10001; 
		public virtual bool isFinished() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				return @__env.CallBooleanMethod(this, _isFinished10001); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Scroller.staticClass, _isFinished10001); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _forceFinished10002; 
		public virtual void forceFinished(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				@__env.CallVoidMethod(this, _forceFinished10002, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Scroller.staticClass, _forceFinished10002, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrX10003; 
		public virtual int getCurrX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				return @__env.CallIntMethod(this, _getCurrX10003); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Scroller.staticClass, _getCurrX10003); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrY10004; 
		public virtual int getCurrY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				return @__env.CallIntMethod(this, _getCurrY10004); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Scroller.staticClass, _getCurrY10004); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartX10005; 
		public virtual int getStartX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				return @__env.CallIntMethod(this, _getStartX10005); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Scroller.staticClass, _getStartX10005); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartY10006; 
		public virtual int getStartY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				return @__env.CallIntMethod(this, _getStartY10006); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Scroller.staticClass, _getStartY10006); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFinalX10007; 
		public virtual int getFinalX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				return @__env.CallIntMethod(this, _getFinalX10007); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Scroller.staticClass, _getFinalX10007); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFinalY10008; 
		public virtual int getFinalY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				return @__env.CallIntMethod(this, _getFinalY10008); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Scroller.staticClass, _getFinalY10008); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScrollOffset10009; 
		public virtual bool computeScrollOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				return @__env.CallBooleanMethod(this, _computeScrollOffset10009); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Scroller.staticClass, _computeScrollOffset10009); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startScroll10010; 
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				@__env.CallVoidMethod(this, _startScroll10010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Scroller.staticClass, _startScroll10010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startScroll10011; 
		public virtual void startScroll(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				@__env.CallVoidMethod(this, _startScroll10011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Scroller.staticClass, _startScroll10011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fling10012; 
		public virtual void fling(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				@__env.CallVoidMethod(this, _fling10012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Scroller.staticClass, _fling10012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _abortAnimation10013; 
		public virtual void abortAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				@__env.CallVoidMethod(this, _abortAnimation10013); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Scroller.staticClass, _abortAnimation10013); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extendDuration10014; 
		public virtual void extendDuration(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				@__env.CallVoidMethod(this, _extendDuration10014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Scroller.staticClass, _extendDuration10014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _timePassed10015; 
		public virtual int timePassed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				return @__env.CallIntMethod(this, _timePassed10015); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Scroller.staticClass, _timePassed10015); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFinalX10016; 
		public virtual void setFinalX(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				@__env.CallVoidMethod(this, _setFinalX10016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Scroller.staticClass, _setFinalX10016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFinalY10017; 
		public virtual void setFinalY(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Scroller)) 
				@__env.CallVoidMethod(this, _setFinalY10017, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Scroller.staticClass, _setFinalY10017, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Scroller10018; 
		public Scroller(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Scroller.staticClass, _Scroller10018, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Scroller10019; 
		public Scroller(android.content.Context arg0, android.view.animation.Interpolator arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Scroller.staticClass, _Scroller10019, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.Scroller.staticClass = @__class; 
			global::android.widget.Scroller._getDuration10000 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getDuration", "()I"); 
			global::android.widget.Scroller._isFinished10001 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "isFinished", "()Z"); 
			global::android.widget.Scroller._forceFinished10002 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "forceFinished", "(Z)V"); 
			global::android.widget.Scroller._getCurrX10003 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getCurrX", "()I"); 
			global::android.widget.Scroller._getCurrY10004 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getCurrY", "()I"); 
			global::android.widget.Scroller._getStartX10005 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getStartX", "()I"); 
			global::android.widget.Scroller._getStartY10006 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getStartY", "()I"); 
			global::android.widget.Scroller._getFinalX10007 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getFinalX", "()I"); 
			global::android.widget.Scroller._getFinalY10008 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "getFinalY", "()I"); 
			global::android.widget.Scroller._computeScrollOffset10009 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "computeScrollOffset", "()Z"); 
			global::android.widget.Scroller._startScroll10010 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "startScroll", "(IIII)V"); 
			global::android.widget.Scroller._startScroll10011 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "startScroll", "(IIIII)V"); 
			global::android.widget.Scroller._fling10012 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "fling", "(IIIIIIII)V"); 
			global::android.widget.Scroller._abortAnimation10013 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "abortAnimation", "()V"); 
			global::android.widget.Scroller._extendDuration10014 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "extendDuration", "(I)V"); 
			global::android.widget.Scroller._timePassed10015 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "timePassed", "()I"); 
			global::android.widget.Scroller._setFinalX10016 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "setFinalX", "(I)V"); 
			global::android.widget.Scroller._setFinalY10017 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "setFinalY", "(I)V"); 
			global::android.widget.Scroller._Scroller10018 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.Scroller._Scroller10019 = @__env.GetMethodID(global::android.widget.Scroller.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;)V"); 
		} 
	} 
} 
