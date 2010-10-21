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
		public interface AnimationListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onAnimationStart(android.view.animation.Animation arg0);
			void onAnimationEnd(android.view.animation.Animation arg0);
			void onAnimationRepeat(android.view.animation.Animation arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.animation.Animation.AnimationListener))]
		public sealed partial class AnimationListener_ : java.lang.Object, AnimationListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AnimationListener_()
			{
				InitJNI();
			}
			internal AnimationListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationStart15495;
			 void android.view.animation.Animation.AnimationListener.onAnimationStart(android.view.animation.Animation arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_._onAnimationStart15495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_.staticClass, global::android.view.animation.Animation.AnimationListener_._onAnimationStart15495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationEnd15496;
			 void android.view.animation.Animation.AnimationListener.onAnimationEnd(android.view.animation.Animation arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_._onAnimationEnd15496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_.staticClass, global::android.view.animation.Animation.AnimationListener_._onAnimationEnd15496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationRepeat15497;
			 void android.view.animation.Animation.AnimationListener.onAnimationRepeat(android.view.animation.Animation arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat15497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_.staticClass, global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat15497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.Animation.AnimationListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation$AnimationListener"));
				global::android.view.animation.Animation.AnimationListener_._onAnimationStart15495 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationStart", "(Landroid/view/animation/Animation;)V");
				global::android.view.animation.Animation.AnimationListener_._onAnimationEnd15496 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationEnd", "(Landroid/view/animation/Animation;)V");
				global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat15497 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationRepeat", "(Landroid/view/animation/Animation;)V");
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
			internal static global::MonoJavaBridge.MethodId _Description15498;
			protected Description()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.Description.staticClass, global::android.view.animation.Animation.Description._Description15498);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _type15499;
			public int type
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _type15499);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _value15500;
			public float value
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _value15500);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.Animation.Description.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation$Description"));
				global::android.view.animation.Animation.Description._Description15498 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "<init>", "()V");
				global::android.view.animation.Animation.Description._type15499 = @__env.GetFieldIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "type", "I");
				global::android.view.animation.Animation.Description._value15500 = @__env.GetFieldIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "value", "F");
			}
		}
		internal static global::MonoJavaBridge.MethodId _clone15501;
		protected virtual global::android.view.animation.Animation clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Animation._clone15501)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._clone15501)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _start15502;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._start15502);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._start15502);
		}
		internal static global::MonoJavaBridge.MethodId _reset15503;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._reset15503);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._reset15503);
		}
		internal static global::MonoJavaBridge.MethodId _initialize15504;
		public virtual void initialize(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._initialize15504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._initialize15504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cancel15505;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._cancel15505);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._cancel15505);
		}
		internal static global::MonoJavaBridge.MethodId _resolveSize15506;
		protected virtual float resolveSize(int arg0, float arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.Animation._resolveSize15506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._resolveSize15506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getRepeatCount15507;
		public virtual int getRepeatCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Animation._getRepeatCount15507);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getRepeatCount15507);
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator15508;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setInterpolator15508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setInterpolator15508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator15509;
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setInterpolator15509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setInterpolator15509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolator15510;
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Animation._getInterpolator15510)) as android.view.animation.Interpolator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getInterpolator15510)) as android.view.animation.Interpolator;
		}
		internal static global::MonoJavaBridge.MethodId _isInitialized15511;
		public virtual bool isInitialized() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._isInitialized15511);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._isInitialized15511);
		}
		internal static global::MonoJavaBridge.MethodId _setStartOffset15512;
		public virtual void setStartOffset(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setStartOffset15512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setStartOffset15512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDuration15513;
		public virtual void setDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setDuration15513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setDuration15513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restrictDuration15514;
		public virtual void restrictDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._restrictDuration15514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._restrictDuration15514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scaleCurrentDuration15515;
		public virtual void scaleCurrentDuration(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._scaleCurrentDuration15515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._scaleCurrentDuration15515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStartTime15516;
		public virtual void setStartTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setStartTime15516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setStartTime15516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startNow15517;
		public virtual void startNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._startNow15517);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._startNow15517);
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatMode15518;
		public virtual void setRepeatMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setRepeatMode15518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setRepeatMode15518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatCount15519;
		public virtual void setRepeatCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setRepeatCount15519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setRepeatCount15519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFillEnabled15520;
		public virtual bool isFillEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._isFillEnabled15520);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._isFillEnabled15520);
		}
		internal static global::MonoJavaBridge.MethodId _setFillEnabled15521;
		public virtual void setFillEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setFillEnabled15521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillEnabled15521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillBefore15522;
		public virtual void setFillBefore(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setFillBefore15522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillBefore15522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillAfter15523;
		public virtual void setFillAfter(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setFillAfter15523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillAfter15523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZAdjustment15524;
		public virtual void setZAdjustment(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setZAdjustment15524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setZAdjustment15524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDetachWallpaper15525;
		public virtual void setDetachWallpaper(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setDetachWallpaper15525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setDetachWallpaper15525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStartTime15526;
		public virtual long getStartTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._getStartTime15526);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getStartTime15526);
		}
		internal static global::MonoJavaBridge.MethodId _getDuration15527;
		public virtual long getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._getDuration15527);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getDuration15527);
		}
		internal static global::MonoJavaBridge.MethodId _getStartOffset15528;
		public virtual long getStartOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._getStartOffset15528);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getStartOffset15528);
		}
		internal static global::MonoJavaBridge.MethodId _getRepeatMode15529;
		public virtual int getRepeatMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Animation._getRepeatMode15529);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getRepeatMode15529);
		}
		internal static global::MonoJavaBridge.MethodId _getFillBefore15530;
		public virtual bool getFillBefore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getFillBefore15530);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getFillBefore15530);
		}
		internal static global::MonoJavaBridge.MethodId _getFillAfter15531;
		public virtual bool getFillAfter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getFillAfter15531);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getFillAfter15531);
		}
		internal static global::MonoJavaBridge.MethodId _getZAdjustment15532;
		public virtual int getZAdjustment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Animation._getZAdjustment15532);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getZAdjustment15532);
		}
		internal static global::MonoJavaBridge.MethodId _getDetachWallpaper15533;
		public virtual bool getDetachWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getDetachWallpaper15533);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getDetachWallpaper15533);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeTransformationMatrix15534;
		public virtual bool willChangeTransformationMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._willChangeTransformationMatrix15534);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._willChangeTransformationMatrix15534);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeBounds15535;
		public virtual bool willChangeBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._willChangeBounds15535);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._willChangeBounds15535);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationListener15536;
		public virtual void setAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setAnimationListener15536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setAnimationListener15536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ensureInterpolator15537;
		protected virtual void ensureInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._ensureInterpolator15537);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._ensureInterpolator15537);
		}
		internal static global::MonoJavaBridge.MethodId _computeDurationHint15538;
		public virtual long computeDurationHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._computeDurationHint15538);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._computeDurationHint15538);
		}
		internal static global::MonoJavaBridge.MethodId _getTransformation15539;
		public virtual bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getTransformation15539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getTransformation15539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasStarted15540;
		public virtual bool hasStarted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._hasStarted15540);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._hasStarted15540);
		}
		internal static global::MonoJavaBridge.MethodId _hasEnded15541;
		public virtual bool hasEnded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._hasEnded15541);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._hasEnded15541);
		}
		internal static global::MonoJavaBridge.MethodId _applyTransformation15542;
		protected virtual void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._applyTransformation15542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._applyTransformation15542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Animation15543;
		public Animation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation15543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Animation15544;
		public Animation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation15544);
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
			global::android.view.animation.Animation._clone15501 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "clone", "()Landroid/view/animation/Animation;");
			global::android.view.animation.Animation._start15502 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "start", "()V");
			global::android.view.animation.Animation._reset15503 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "reset", "()V");
			global::android.view.animation.Animation._initialize15504 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.Animation._cancel15505 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "cancel", "()V");
			global::android.view.animation.Animation._resolveSize15506 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "resolveSize", "(IFII)F");
			global::android.view.animation.Animation._getRepeatCount15507 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getRepeatCount", "()I");
			global::android.view.animation.Animation._setInterpolator15508 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.view.animation.Animation._setInterpolator15509 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.view.animation.Animation._getInterpolator15510 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.view.animation.Animation._isInitialized15511 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "isInitialized", "()Z");
			global::android.view.animation.Animation._setStartOffset15512 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setStartOffset", "(J)V");
			global::android.view.animation.Animation._setDuration15513 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setDuration", "(J)V");
			global::android.view.animation.Animation._restrictDuration15514 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "restrictDuration", "(J)V");
			global::android.view.animation.Animation._scaleCurrentDuration15515 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "scaleCurrentDuration", "(F)V");
			global::android.view.animation.Animation._setStartTime15516 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setStartTime", "(J)V");
			global::android.view.animation.Animation._startNow15517 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "startNow", "()V");
			global::android.view.animation.Animation._setRepeatMode15518 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setRepeatMode", "(I)V");
			global::android.view.animation.Animation._setRepeatCount15519 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setRepeatCount", "(I)V");
			global::android.view.animation.Animation._isFillEnabled15520 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "isFillEnabled", "()Z");
			global::android.view.animation.Animation._setFillEnabled15521 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setFillEnabled", "(Z)V");
			global::android.view.animation.Animation._setFillBefore15522 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setFillBefore", "(Z)V");
			global::android.view.animation.Animation._setFillAfter15523 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setFillAfter", "(Z)V");
			global::android.view.animation.Animation._setZAdjustment15524 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setZAdjustment", "(I)V");
			global::android.view.animation.Animation._setDetachWallpaper15525 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setDetachWallpaper", "(Z)V");
			global::android.view.animation.Animation._getStartTime15526 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getStartTime", "()J");
			global::android.view.animation.Animation._getDuration15527 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getDuration", "()J");
			global::android.view.animation.Animation._getStartOffset15528 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getStartOffset", "()J");
			global::android.view.animation.Animation._getRepeatMode15529 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getRepeatMode", "()I");
			global::android.view.animation.Animation._getFillBefore15530 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getFillBefore", "()Z");
			global::android.view.animation.Animation._getFillAfter15531 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getFillAfter", "()Z");
			global::android.view.animation.Animation._getZAdjustment15532 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getZAdjustment", "()I");
			global::android.view.animation.Animation._getDetachWallpaper15533 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getDetachWallpaper", "()Z");
			global::android.view.animation.Animation._willChangeTransformationMatrix15534 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "willChangeTransformationMatrix", "()Z");
			global::android.view.animation.Animation._willChangeBounds15535 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "willChangeBounds", "()Z");
			global::android.view.animation.Animation._setAnimationListener15536 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V");
			global::android.view.animation.Animation._ensureInterpolator15537 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "ensureInterpolator", "()V");
			global::android.view.animation.Animation._computeDurationHint15538 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "computeDurationHint", "()J");
			global::android.view.animation.Animation._getTransformation15539 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z");
			global::android.view.animation.Animation._hasStarted15540 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "hasStarted", "()Z");
			global::android.view.animation.Animation._hasEnded15541 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "hasEnded", "()Z");
			global::android.view.animation.Animation._applyTransformation15542 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V");
			global::android.view.animation.Animation._Animation15543 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.Animation._Animation15544 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.animation.Animation))]
	public sealed partial class Animation_ : android.view.animation.Animation
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
