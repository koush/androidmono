namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Animation : java.lang.Object, java.lang.Cloneable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Animation() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.Animation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Animation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface AnimationListener 
		{ 
			void onAnimationStart(android.view.animation.Animation arg0); 
			void onAnimationEnd(android.view.animation.Animation arg0); 
			void onAnimationRepeat(android.view.animation.Animation arg0); 
		} 

		public partial class AnimationListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __AnimationListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __AnimationListener : java.lang.Object, AnimationListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __AnimationListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.Animation.__AnimationListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.animation.Animation.__AnimationListener(@__env); 
				} 
			} 
			internal __AnimationListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onAnimationStart8847; 
			 void android.view.animation.Animation.AnimationListener.onAnimationStart(android.view.animation.Animation arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.animation.Animation.__AnimationListener._onAnimationStart8847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.__AnimationListener.staticClass, global::android.view.animation.Animation.__AnimationListener._onAnimationStart8847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onAnimationEnd8848; 
			 void android.view.animation.Animation.AnimationListener.onAnimationEnd(android.view.animation.Animation arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.animation.Animation.__AnimationListener._onAnimationEnd8848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.__AnimationListener.staticClass, global::android.view.animation.Animation.__AnimationListener._onAnimationEnd8848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onAnimationRepeat8849; 
			 void android.view.animation.Animation.AnimationListener.onAnimationRepeat(android.view.animation.Animation arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.animation.Animation.__AnimationListener._onAnimationRepeat8849, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.__AnimationListener.staticClass, global::android.view.animation.Animation.__AnimationListener._onAnimationRepeat8849, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.animation.Animation.__AnimationListener.staticClass = @__class; 
				global::android.view.animation.Animation.__AnimationListener._onAnimationStart8847 = @__env.GetMethodID(global::android.view.animation.Animation.__AnimationListener.staticClass, "android.view.animation.Animation.AnimationListener.onAnimationStart", "(Landroid/view/animation/Animation;)V"); 
				global::android.view.animation.Animation.__AnimationListener._onAnimationEnd8848 = @__env.GetMethodID(global::android.view.animation.Animation.__AnimationListener.staticClass, "android.view.animation.Animation.AnimationListener.onAnimationEnd", "(Landroid/view/animation/Animation;)V"); 
				global::android.view.animation.Animation.__AnimationListener._onAnimationRepeat8849 = @__env.GetMethodID(global::android.view.animation.Animation.__AnimationListener.staticClass, "android.view.animation.Animation.AnimationListener.onAnimationRepeat", "(Landroid/view/animation/Animation;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected class Description : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Description() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.Animation.Description), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.animation.Animation.Description(@__env); 
				} 
			} 
			protected Description(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Description8850; 
			protected Description()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.animation.Animation.Description.staticClass, global::android.view.animation.Animation.Description._Description8850, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _type8851; 
			public int type
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _value8852; 
			public float value
			{ 
				get 
				{ 
					return default(float); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.animation.Animation.Description.staticClass = @__class; 
				global::android.view.animation.Animation.Description._Description8850 = @__env.GetMethodID(global::android.view.animation.Animation.Description.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone8853; 
		protected virtual global::android.view.animation.Animation clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.Animation._clone8853)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._clone8853)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start8854; 
		public virtual void start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._start8854); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._start8854); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset8855; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._reset8855); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._reset8855); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _initialize8856; 
		public virtual void initialize(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._initialize8856, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._initialize8856, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolveSize8857; 
		protected virtual float resolveSize(int arg0, float arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.view.animation.Animation._resolveSize8857, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._resolveSize8857, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRepeatCount8858; 
		public virtual int getRepeatCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.animation.Animation._getRepeatCount8858); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getRepeatCount8858); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator8859; 
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setInterpolator8859, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setInterpolator8859, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator8860; 
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setInterpolator8860, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setInterpolator8860, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolator8861; 
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.Animation._getInterpolator8861)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getInterpolator8861)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInitialized8862; 
		public virtual bool isInitialized() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._isInitialized8862); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._isInitialized8862); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStartOffset8863; 
		public virtual void setStartOffset(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setStartOffset8863, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setStartOffset8863, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDuration8864; 
		public virtual void setDuration(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setDuration8864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setDuration8864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restrictDuration8865; 
		public virtual void restrictDuration(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._restrictDuration8865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._restrictDuration8865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scaleCurrentDuration8866; 
		public virtual void scaleCurrentDuration(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._scaleCurrentDuration8866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._scaleCurrentDuration8866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStartTime8867; 
		public virtual void setStartTime(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setStartTime8867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setStartTime8867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startNow8868; 
		public virtual void startNow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._startNow8868); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._startNow8868); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRepeatMode8869; 
		public virtual void setRepeatMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setRepeatMode8869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setRepeatMode8869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRepeatCount8870; 
		public virtual void setRepeatCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setRepeatCount8870, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setRepeatCount8870, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFillEnabled8871; 
		public virtual bool isFillEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._isFillEnabled8871); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._isFillEnabled8871); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillEnabled8872; 
		public virtual void setFillEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setFillEnabled8872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillEnabled8872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillBefore8873; 
		public virtual void setFillBefore(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setFillBefore8873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillBefore8873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillAfter8874; 
		public virtual void setFillAfter(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setFillAfter8874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillAfter8874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZAdjustment8875; 
		public virtual void setZAdjustment(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setZAdjustment8875, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setZAdjustment8875, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDetachWallpaper8876; 
		public virtual void setDetachWallpaper(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setDetachWallpaper8876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setDetachWallpaper8876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartTime8877; 
		public virtual long getStartTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.view.animation.Animation._getStartTime8877); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getStartTime8877); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDuration8878; 
		public virtual long getDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.view.animation.Animation._getDuration8878); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getDuration8878); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartOffset8879; 
		public virtual long getStartOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.view.animation.Animation._getStartOffset8879); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getStartOffset8879); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRepeatMode8880; 
		public virtual int getRepeatMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.animation.Animation._getRepeatMode8880); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getRepeatMode8880); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFillBefore8881; 
		public virtual bool getFillBefore() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._getFillBefore8881); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getFillBefore8881); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFillAfter8882; 
		public virtual bool getFillAfter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._getFillAfter8882); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getFillAfter8882); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getZAdjustment8883; 
		public virtual int getZAdjustment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.animation.Animation._getZAdjustment8883); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getZAdjustment8883); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDetachWallpaper8884; 
		public virtual bool getDetachWallpaper() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._getDetachWallpaper8884); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getDetachWallpaper8884); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willChangeTransformationMatrix8885; 
		public virtual bool willChangeTransformationMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._willChangeTransformationMatrix8885); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._willChangeTransformationMatrix8885); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willChangeBounds8886; 
		public virtual bool willChangeBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._willChangeBounds8886); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._willChangeBounds8886); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimationListener8887; 
		public virtual void setAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._setAnimationListener8887, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setAnimationListener8887, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ensureInterpolator8888; 
		protected virtual void ensureInterpolator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._ensureInterpolator8888); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._ensureInterpolator8888); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeDurationHint8889; 
		public virtual long computeDurationHint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.view.animation.Animation._computeDurationHint8889); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._computeDurationHint8889); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransformation8890; 
		public virtual bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._getTransformation8890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getTransformation8890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStarted8891; 
		public virtual bool hasStarted() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._hasStarted8891); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._hasStarted8891); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasEnded8892; 
		public virtual bool hasEnded() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.Animation._hasEnded8892); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._hasEnded8892); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _applyTransformation8893; 
		protected virtual void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.animation.Animation._applyTransformation8893, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._applyTransformation8893, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Animation8894; 
		public Animation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation8894, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Animation8895; 
		public Animation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation8895, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		public static int INFINITE
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		public static int RESTART
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int REVERSE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int START_ON_FIRST_FRAME
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		public static int ABSOLUTE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int RELATIVE_TO_SELF
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int RELATIVE_TO_PARENT
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int ZORDER_NORMAL
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int ZORDER_TOP
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int ZORDER_BOTTOM
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.Animation.staticClass = @__class; 
			global::android.view.animation.Animation._clone8853 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "clone", "()Landroid/view/animation/Animation;"); 
			global::android.view.animation.Animation._start8854 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "start", "()V"); 
			global::android.view.animation.Animation._reset8855 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "reset", "()V"); 
			global::android.view.animation.Animation._initialize8856 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "initialize", "(IIII)V"); 
			global::android.view.animation.Animation._resolveSize8857 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "resolveSize", "(IFII)F"); 
			global::android.view.animation.Animation._getRepeatCount8858 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getRepeatCount", "()I"); 
			global::android.view.animation.Animation._setInterpolator8859 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V"); 
			global::android.view.animation.Animation._setInterpolator8860 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/content/Context;I)V"); 
			global::android.view.animation.Animation._getInterpolator8861 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;"); 
			global::android.view.animation.Animation._isInitialized8862 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "isInitialized", "()Z"); 
			global::android.view.animation.Animation._setStartOffset8863 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setStartOffset", "(J)V"); 
			global::android.view.animation.Animation._setDuration8864 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setDuration", "(J)V"); 
			global::android.view.animation.Animation._restrictDuration8865 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "restrictDuration", "(J)V"); 
			global::android.view.animation.Animation._scaleCurrentDuration8866 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "scaleCurrentDuration", "(F)V"); 
			global::android.view.animation.Animation._setStartTime8867 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setStartTime", "(J)V"); 
			global::android.view.animation.Animation._startNow8868 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "startNow", "()V"); 
			global::android.view.animation.Animation._setRepeatMode8869 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setRepeatMode", "(I)V"); 
			global::android.view.animation.Animation._setRepeatCount8870 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setRepeatCount", "(I)V"); 
			global::android.view.animation.Animation._isFillEnabled8871 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "isFillEnabled", "()Z"); 
			global::android.view.animation.Animation._setFillEnabled8872 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setFillEnabled", "(Z)V"); 
			global::android.view.animation.Animation._setFillBefore8873 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setFillBefore", "(Z)V"); 
			global::android.view.animation.Animation._setFillAfter8874 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setFillAfter", "(Z)V"); 
			global::android.view.animation.Animation._setZAdjustment8875 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setZAdjustment", "(I)V"); 
			global::android.view.animation.Animation._setDetachWallpaper8876 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setDetachWallpaper", "(Z)V"); 
			global::android.view.animation.Animation._getStartTime8877 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getStartTime", "()J"); 
			global::android.view.animation.Animation._getDuration8878 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getDuration", "()J"); 
			global::android.view.animation.Animation._getStartOffset8879 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getStartOffset", "()J"); 
			global::android.view.animation.Animation._getRepeatMode8880 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getRepeatMode", "()I"); 
			global::android.view.animation.Animation._getFillBefore8881 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getFillBefore", "()Z"); 
			global::android.view.animation.Animation._getFillAfter8882 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getFillAfter", "()Z"); 
			global::android.view.animation.Animation._getZAdjustment8883 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getZAdjustment", "()I"); 
			global::android.view.animation.Animation._getDetachWallpaper8884 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getDetachWallpaper", "()Z"); 
			global::android.view.animation.Animation._willChangeTransformationMatrix8885 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "willChangeTransformationMatrix", "()Z"); 
			global::android.view.animation.Animation._willChangeBounds8886 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "willChangeBounds", "()Z"); 
			global::android.view.animation.Animation._setAnimationListener8887 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V"); 
			global::android.view.animation.Animation._ensureInterpolator8888 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "ensureInterpolator", "()V"); 
			global::android.view.animation.Animation._computeDurationHint8889 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "computeDurationHint", "()J"); 
			global::android.view.animation.Animation._getTransformation8890 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z"); 
			global::android.view.animation.Animation._hasStarted8891 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "hasStarted", "()Z"); 
			global::android.view.animation.Animation._hasEnded8892 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "hasEnded", "()Z"); 
			global::android.view.animation.Animation._applyTransformation8893 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V"); 
			global::android.view.animation.Animation._Animation8894 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "<init>", "()V"); 
			global::android.view.animation.Animation._Animation8895 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
