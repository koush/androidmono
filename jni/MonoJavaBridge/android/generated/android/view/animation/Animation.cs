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
			internal static global::MonoJavaBridge.MethodId _onAnimationStart10446;
			 void android.view.animation.Animation.AnimationListener.onAnimationStart(android.view.animation.Animation arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_._onAnimationStart10446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_.staticClass, global::android.view.animation.Animation.AnimationListener_._onAnimationStart10446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationEnd10447;
			 void android.view.animation.Animation.AnimationListener.onAnimationEnd(android.view.animation.Animation arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_._onAnimationEnd10447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_.staticClass, global::android.view.animation.Animation.AnimationListener_._onAnimationEnd10447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationRepeat10448;
			 void android.view.animation.Animation.AnimationListener.onAnimationRepeat(android.view.animation.Animation arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat10448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_.staticClass, global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat10448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.Animation.AnimationListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation$AnimationListener"));
				global::android.view.animation.Animation.AnimationListener_._onAnimationStart10446 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationStart", "(Landroid/view/animation/Animation;)V");
				global::android.view.animation.Animation.AnimationListener_._onAnimationEnd10447 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationEnd", "(Landroid/view/animation/Animation;)V");
				global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat10448 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationRepeat", "(Landroid/view/animation/Animation;)V");
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
			internal static global::MonoJavaBridge.MethodId _Description10449;
			protected Description()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.Description.staticClass, global::android.view.animation.Animation.Description._Description10449);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _type10450;
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
			internal static global::MonoJavaBridge.FieldId _value10451;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.Animation.Description.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation$Description"));
				global::android.view.animation.Animation.Description._Description10449 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _clone10452;
		protected virtual global::android.view.animation.Animation clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Animation._clone10452)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._clone10452)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _start10453;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._start10453);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._start10453);
		}
		internal static global::MonoJavaBridge.MethodId _reset10454;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._reset10454);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._reset10454);
		}
		internal static global::MonoJavaBridge.MethodId _initialize10455;
		public virtual void initialize(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._initialize10455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._initialize10455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cancel10456;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._cancel10456);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._cancel10456);
		}
		internal static global::MonoJavaBridge.MethodId _resolveSize10457;
		protected virtual float resolveSize(int arg0, float arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.Animation._resolveSize10457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._resolveSize10457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getRepeatCount10458;
		public virtual int getRepeatCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Animation._getRepeatCount10458);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getRepeatCount10458);
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator10459;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setInterpolator10459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setInterpolator10459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator10460;
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setInterpolator10460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setInterpolator10460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolator10461;
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Animation._getInterpolator10461)) as android.view.animation.Interpolator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getInterpolator10461)) as android.view.animation.Interpolator;
		}
		internal static global::MonoJavaBridge.MethodId _isInitialized10462;
		public virtual bool isInitialized() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._isInitialized10462);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._isInitialized10462);
		}
		internal static global::MonoJavaBridge.MethodId _setStartOffset10463;
		public virtual void setStartOffset(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setStartOffset10463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setStartOffset10463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDuration10464;
		public virtual void setDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setDuration10464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setDuration10464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restrictDuration10465;
		public virtual void restrictDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._restrictDuration10465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._restrictDuration10465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scaleCurrentDuration10466;
		public virtual void scaleCurrentDuration(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._scaleCurrentDuration10466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._scaleCurrentDuration10466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStartTime10467;
		public virtual void setStartTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setStartTime10467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setStartTime10467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startNow10468;
		public virtual void startNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._startNow10468);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._startNow10468);
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatMode10469;
		public virtual void setRepeatMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setRepeatMode10469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setRepeatMode10469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatCount10470;
		public virtual void setRepeatCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setRepeatCount10470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setRepeatCount10470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFillEnabled10471;
		public virtual bool isFillEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._isFillEnabled10471);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._isFillEnabled10471);
		}
		internal static global::MonoJavaBridge.MethodId _setFillEnabled10472;
		public virtual void setFillEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setFillEnabled10472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillEnabled10472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillBefore10473;
		public virtual void setFillBefore(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setFillBefore10473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillBefore10473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillAfter10474;
		public virtual void setFillAfter(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setFillAfter10474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillAfter10474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZAdjustment10475;
		public virtual void setZAdjustment(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setZAdjustment10475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setZAdjustment10475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDetachWallpaper10476;
		public virtual void setDetachWallpaper(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setDetachWallpaper10476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setDetachWallpaper10476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStartTime10477;
		public virtual long getStartTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._getStartTime10477);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getStartTime10477);
		}
		internal static global::MonoJavaBridge.MethodId _getDuration10478;
		public virtual long getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._getDuration10478);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getDuration10478);
		}
		internal static global::MonoJavaBridge.MethodId _getStartOffset10479;
		public virtual long getStartOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._getStartOffset10479);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getStartOffset10479);
		}
		internal static global::MonoJavaBridge.MethodId _getRepeatMode10480;
		public virtual int getRepeatMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Animation._getRepeatMode10480);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getRepeatMode10480);
		}
		internal static global::MonoJavaBridge.MethodId _getFillBefore10481;
		public virtual bool getFillBefore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getFillBefore10481);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getFillBefore10481);
		}
		internal static global::MonoJavaBridge.MethodId _getFillAfter10482;
		public virtual bool getFillAfter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getFillAfter10482);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getFillAfter10482);
		}
		internal static global::MonoJavaBridge.MethodId _getZAdjustment10483;
		public virtual int getZAdjustment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Animation._getZAdjustment10483);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getZAdjustment10483);
		}
		internal static global::MonoJavaBridge.MethodId _getDetachWallpaper10484;
		public virtual bool getDetachWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getDetachWallpaper10484);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getDetachWallpaper10484);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeTransformationMatrix10485;
		public virtual bool willChangeTransformationMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._willChangeTransformationMatrix10485);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._willChangeTransformationMatrix10485);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeBounds10486;
		public virtual bool willChangeBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._willChangeBounds10486);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._willChangeBounds10486);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationListener10487;
		public virtual void setAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setAnimationListener10487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setAnimationListener10487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ensureInterpolator10488;
		protected virtual void ensureInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._ensureInterpolator10488);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._ensureInterpolator10488);
		}
		internal static global::MonoJavaBridge.MethodId _computeDurationHint10489;
		public virtual long computeDurationHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._computeDurationHint10489);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._computeDurationHint10489);
		}
		internal static global::MonoJavaBridge.MethodId _getTransformation10490;
		public virtual bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getTransformation10490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getTransformation10490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasStarted10491;
		public virtual bool hasStarted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._hasStarted10491);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._hasStarted10491);
		}
		internal static global::MonoJavaBridge.MethodId _hasEnded10492;
		public virtual bool hasEnded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._hasEnded10492);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._hasEnded10492);
		}
		internal static global::MonoJavaBridge.MethodId _applyTransformation10493;
		protected virtual void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._applyTransformation10493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._applyTransformation10493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Animation10494;
		public Animation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation10494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Animation10495;
		public Animation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation10495);
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
			global::android.view.animation.Animation._clone10452 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "clone", "()Landroid/view/animation/Animation;");
			global::android.view.animation.Animation._start10453 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "start", "()V");
			global::android.view.animation.Animation._reset10454 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "reset", "()V");
			global::android.view.animation.Animation._initialize10455 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.Animation._cancel10456 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "cancel", "()V");
			global::android.view.animation.Animation._resolveSize10457 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "resolveSize", "(IFII)F");
			global::android.view.animation.Animation._getRepeatCount10458 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getRepeatCount", "()I");
			global::android.view.animation.Animation._setInterpolator10459 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.view.animation.Animation._setInterpolator10460 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.view.animation.Animation._getInterpolator10461 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.view.animation.Animation._isInitialized10462 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "isInitialized", "()Z");
			global::android.view.animation.Animation._setStartOffset10463 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setStartOffset", "(J)V");
			global::android.view.animation.Animation._setDuration10464 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setDuration", "(J)V");
			global::android.view.animation.Animation._restrictDuration10465 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "restrictDuration", "(J)V");
			global::android.view.animation.Animation._scaleCurrentDuration10466 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "scaleCurrentDuration", "(F)V");
			global::android.view.animation.Animation._setStartTime10467 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setStartTime", "(J)V");
			global::android.view.animation.Animation._startNow10468 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "startNow", "()V");
			global::android.view.animation.Animation._setRepeatMode10469 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setRepeatMode", "(I)V");
			global::android.view.animation.Animation._setRepeatCount10470 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setRepeatCount", "(I)V");
			global::android.view.animation.Animation._isFillEnabled10471 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "isFillEnabled", "()Z");
			global::android.view.animation.Animation._setFillEnabled10472 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setFillEnabled", "(Z)V");
			global::android.view.animation.Animation._setFillBefore10473 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setFillBefore", "(Z)V");
			global::android.view.animation.Animation._setFillAfter10474 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setFillAfter", "(Z)V");
			global::android.view.animation.Animation._setZAdjustment10475 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setZAdjustment", "(I)V");
			global::android.view.animation.Animation._setDetachWallpaper10476 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setDetachWallpaper", "(Z)V");
			global::android.view.animation.Animation._getStartTime10477 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getStartTime", "()J");
			global::android.view.animation.Animation._getDuration10478 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getDuration", "()J");
			global::android.view.animation.Animation._getStartOffset10479 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getStartOffset", "()J");
			global::android.view.animation.Animation._getRepeatMode10480 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getRepeatMode", "()I");
			global::android.view.animation.Animation._getFillBefore10481 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getFillBefore", "()Z");
			global::android.view.animation.Animation._getFillAfter10482 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getFillAfter", "()Z");
			global::android.view.animation.Animation._getZAdjustment10483 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getZAdjustment", "()I");
			global::android.view.animation.Animation._getDetachWallpaper10484 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getDetachWallpaper", "()Z");
			global::android.view.animation.Animation._willChangeTransformationMatrix10485 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "willChangeTransformationMatrix", "()Z");
			global::android.view.animation.Animation._willChangeBounds10486 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "willChangeBounds", "()Z");
			global::android.view.animation.Animation._setAnimationListener10487 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V");
			global::android.view.animation.Animation._ensureInterpolator10488 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "ensureInterpolator", "()V");
			global::android.view.animation.Animation._computeDurationHint10489 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "computeDurationHint", "()J");
			global::android.view.animation.Animation._getTransformation10490 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z");
			global::android.view.animation.Animation._hasStarted10491 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "hasStarted", "()Z");
			global::android.view.animation.Animation._hasEnded10492 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "hasEnded", "()Z");
			global::android.view.animation.Animation._applyTransformation10493 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V");
			global::android.view.animation.Animation._Animation10494 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.Animation._Animation10495 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "<init>", "()V");
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
