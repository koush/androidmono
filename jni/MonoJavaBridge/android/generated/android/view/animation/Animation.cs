namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.animation.Animation_))]
	public abstract partial class Animation : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Animation()
		{
			InitJNI();
		}
		protected Animation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.animation.Animation.AnimationListener_))]
		public partial interface AnimationListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onAnimationStart(android.view.animation.Animation arg0);
			void onAnimationEnd(android.view.animation.Animation arg0);
			void onAnimationRepeat(android.view.animation.Animation arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.animation.Animation.AnimationListener))]
		internal sealed partial class AnimationListener_ : java.lang.Object, AnimationListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AnimationListener_()
			{
				InitJNI();
			}
			internal AnimationListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationStart15575;
			 void android.view.animation.Animation.AnimationListener.onAnimationStart(android.view.animation.Animation arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_._onAnimationStart15575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_.staticClass, global::android.view.animation.Animation.AnimationListener_._onAnimationStart15575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationEnd15576;
			 void android.view.animation.Animation.AnimationListener.onAnimationEnd(android.view.animation.Animation arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_._onAnimationEnd15576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_.staticClass, global::android.view.animation.Animation.AnimationListener_._onAnimationEnd15576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationRepeat15577;
			 void android.view.animation.Animation.AnimationListener.onAnimationRepeat(android.view.animation.Animation arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat15577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_.staticClass, global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat15577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.Animation.AnimationListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation$AnimationListener"));
				global::android.view.animation.Animation.AnimationListener_._onAnimationStart15575 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationStart", "(Landroid/view/animation/Animation;)V");
				global::android.view.animation.Animation.AnimationListener_._onAnimationEnd15576 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationEnd", "(Landroid/view/animation/Animation;)V");
				global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat15577 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationRepeat", "(Landroid/view/animation/Animation;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class Description : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Description()
			{
				InitJNI();
			}
			protected Description(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _Description15578;
			protected Description()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.Description.staticClass, global::android.view.animation.Animation.Description._Description15578);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _type15579;
			public int type
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _type15579);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _value15580;
			public float value
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _value15580);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.Animation.Description.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation$Description"));
				global::android.view.animation.Animation.Description._Description15578 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "<init>", "()V");
				global::android.view.animation.Animation.Description._type15579 = @__env.GetFieldIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "type", "I");
				global::android.view.animation.Animation.Description._value15580 = @__env.GetFieldIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "value", "F");
			}
		}
		internal static global::MonoJavaBridge.MethodId _clone15581;
		protected virtual global::android.view.animation.Animation clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Animation._clone15581)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._clone15581)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _start15582;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._start15582);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._start15582);
		}
		internal static global::MonoJavaBridge.MethodId _reset15583;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._reset15583);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._reset15583);
		}
		internal static global::MonoJavaBridge.MethodId _initialize15584;
		public virtual void initialize(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._initialize15584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._initialize15584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cancel15585;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._cancel15585);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._cancel15585);
		}
		internal static global::MonoJavaBridge.MethodId _resolveSize15586;
		protected virtual float resolveSize(int arg0, float arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.Animation._resolveSize15586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._resolveSize15586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getRepeatCount15587;
		public virtual int getRepeatCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Animation._getRepeatCount15587);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getRepeatCount15587);
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator15588;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setInterpolator15588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setInterpolator15588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setInterpolator(global::android.view.animation.InterpolatorDelegate arg0)
		{
			setInterpolator((global::android.view.animation.InterpolatorDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator15589;
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setInterpolator15589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setInterpolator15589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolator15590;
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Animation._getInterpolator15590)) as android.view.animation.Interpolator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getInterpolator15590)) as android.view.animation.Interpolator;
		}
		internal static global::MonoJavaBridge.MethodId _isInitialized15591;
		public virtual bool isInitialized() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._isInitialized15591);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._isInitialized15591);
		}
		internal static global::MonoJavaBridge.MethodId _setStartOffset15592;
		public virtual void setStartOffset(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setStartOffset15592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setStartOffset15592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDuration15593;
		public virtual void setDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setDuration15593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setDuration15593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restrictDuration15594;
		public virtual void restrictDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._restrictDuration15594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._restrictDuration15594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scaleCurrentDuration15595;
		public virtual void scaleCurrentDuration(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._scaleCurrentDuration15595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._scaleCurrentDuration15595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStartTime15596;
		public virtual void setStartTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setStartTime15596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setStartTime15596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startNow15597;
		public virtual void startNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._startNow15597);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._startNow15597);
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatMode15598;
		public virtual void setRepeatMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setRepeatMode15598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setRepeatMode15598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatCount15599;
		public virtual void setRepeatCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setRepeatCount15599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setRepeatCount15599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFillEnabled15600;
		public virtual bool isFillEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._isFillEnabled15600);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._isFillEnabled15600);
		}
		internal static global::MonoJavaBridge.MethodId _setFillEnabled15601;
		public virtual void setFillEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setFillEnabled15601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillEnabled15601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillBefore15602;
		public virtual void setFillBefore(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setFillBefore15602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillBefore15602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillAfter15603;
		public virtual void setFillAfter(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setFillAfter15603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillAfter15603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZAdjustment15604;
		public virtual void setZAdjustment(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setZAdjustment15604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setZAdjustment15604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDetachWallpaper15605;
		public virtual void setDetachWallpaper(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setDetachWallpaper15605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setDetachWallpaper15605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStartTime15606;
		public virtual long getStartTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._getStartTime15606);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getStartTime15606);
		}
		internal static global::MonoJavaBridge.MethodId _getDuration15607;
		public virtual long getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._getDuration15607);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getDuration15607);
		}
		internal static global::MonoJavaBridge.MethodId _getStartOffset15608;
		public virtual long getStartOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._getStartOffset15608);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getStartOffset15608);
		}
		internal static global::MonoJavaBridge.MethodId _getRepeatMode15609;
		public virtual int getRepeatMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Animation._getRepeatMode15609);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getRepeatMode15609);
		}
		internal static global::MonoJavaBridge.MethodId _getFillBefore15610;
		public virtual bool getFillBefore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getFillBefore15610);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getFillBefore15610);
		}
		internal static global::MonoJavaBridge.MethodId _getFillAfter15611;
		public virtual bool getFillAfter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getFillAfter15611);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getFillAfter15611);
		}
		internal static global::MonoJavaBridge.MethodId _getZAdjustment15612;
		public virtual int getZAdjustment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Animation._getZAdjustment15612);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getZAdjustment15612);
		}
		internal static global::MonoJavaBridge.MethodId _getDetachWallpaper15613;
		public virtual bool getDetachWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getDetachWallpaper15613);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getDetachWallpaper15613);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeTransformationMatrix15614;
		public virtual bool willChangeTransformationMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._willChangeTransformationMatrix15614);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._willChangeTransformationMatrix15614);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeBounds15615;
		public virtual bool willChangeBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._willChangeBounds15615);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._willChangeBounds15615);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationListener15616;
		public virtual void setAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setAnimationListener15616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setAnimationListener15616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ensureInterpolator15617;
		protected virtual void ensureInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._ensureInterpolator15617);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._ensureInterpolator15617);
		}
		internal static global::MonoJavaBridge.MethodId _computeDurationHint15618;
		public virtual long computeDurationHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._computeDurationHint15618);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._computeDurationHint15618);
		}
		internal static global::MonoJavaBridge.MethodId _getTransformation15619;
		public virtual bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getTransformation15619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getTransformation15619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasStarted15620;
		public virtual bool hasStarted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._hasStarted15620);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._hasStarted15620);
		}
		internal static global::MonoJavaBridge.MethodId _hasEnded15621;
		public virtual bool hasEnded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._hasEnded15621);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._hasEnded15621);
		}
		internal static global::MonoJavaBridge.MethodId _applyTransformation15622;
		protected virtual void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._applyTransformation15622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._applyTransformation15622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Animation15623;
		public Animation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation15623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Animation15624;
		public Animation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation15624);
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.Animation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation"));
			global::android.view.animation.Animation._clone15581 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "clone", "()Landroid/view/animation/Animation;");
			global::android.view.animation.Animation._start15582 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "start", "()V");
			global::android.view.animation.Animation._reset15583 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "reset", "()V");
			global::android.view.animation.Animation._initialize15584 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.Animation._cancel15585 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "cancel", "()V");
			global::android.view.animation.Animation._resolveSize15586 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "resolveSize", "(IFII)F");
			global::android.view.animation.Animation._getRepeatCount15587 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getRepeatCount", "()I");
			global::android.view.animation.Animation._setInterpolator15588 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.view.animation.Animation._setInterpolator15589 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.view.animation.Animation._getInterpolator15590 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.view.animation.Animation._isInitialized15591 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "isInitialized", "()Z");
			global::android.view.animation.Animation._setStartOffset15592 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setStartOffset", "(J)V");
			global::android.view.animation.Animation._setDuration15593 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setDuration", "(J)V");
			global::android.view.animation.Animation._restrictDuration15594 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "restrictDuration", "(J)V");
			global::android.view.animation.Animation._scaleCurrentDuration15595 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "scaleCurrentDuration", "(F)V");
			global::android.view.animation.Animation._setStartTime15596 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setStartTime", "(J)V");
			global::android.view.animation.Animation._startNow15597 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "startNow", "()V");
			global::android.view.animation.Animation._setRepeatMode15598 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setRepeatMode", "(I)V");
			global::android.view.animation.Animation._setRepeatCount15599 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setRepeatCount", "(I)V");
			global::android.view.animation.Animation._isFillEnabled15600 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "isFillEnabled", "()Z");
			global::android.view.animation.Animation._setFillEnabled15601 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setFillEnabled", "(Z)V");
			global::android.view.animation.Animation._setFillBefore15602 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setFillBefore", "(Z)V");
			global::android.view.animation.Animation._setFillAfter15603 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setFillAfter", "(Z)V");
			global::android.view.animation.Animation._setZAdjustment15604 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setZAdjustment", "(I)V");
			global::android.view.animation.Animation._setDetachWallpaper15605 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setDetachWallpaper", "(Z)V");
			global::android.view.animation.Animation._getStartTime15606 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getStartTime", "()J");
			global::android.view.animation.Animation._getDuration15607 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getDuration", "()J");
			global::android.view.animation.Animation._getStartOffset15608 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getStartOffset", "()J");
			global::android.view.animation.Animation._getRepeatMode15609 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getRepeatMode", "()I");
			global::android.view.animation.Animation._getFillBefore15610 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getFillBefore", "()Z");
			global::android.view.animation.Animation._getFillAfter15611 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getFillAfter", "()Z");
			global::android.view.animation.Animation._getZAdjustment15612 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getZAdjustment", "()I");
			global::android.view.animation.Animation._getDetachWallpaper15613 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getDetachWallpaper", "()Z");
			global::android.view.animation.Animation._willChangeTransformationMatrix15614 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "willChangeTransformationMatrix", "()Z");
			global::android.view.animation.Animation._willChangeBounds15615 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "willChangeBounds", "()Z");
			global::android.view.animation.Animation._setAnimationListener15616 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V");
			global::android.view.animation.Animation._ensureInterpolator15617 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "ensureInterpolator", "()V");
			global::android.view.animation.Animation._computeDurationHint15618 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "computeDurationHint", "()J");
			global::android.view.animation.Animation._getTransformation15619 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z");
			global::android.view.animation.Animation._hasStarted15620 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "hasStarted", "()Z");
			global::android.view.animation.Animation._hasEnded15621 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "hasEnded", "()Z");
			global::android.view.animation.Animation._applyTransformation15622 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V");
			global::android.view.animation.Animation._Animation15623 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.Animation._Animation15624 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.animation.Animation))]
	internal sealed partial class Animation_ : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Animation_()
		{
			InitJNI();
		}
		internal Animation_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.Animation_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation"));
		}
	}
}
