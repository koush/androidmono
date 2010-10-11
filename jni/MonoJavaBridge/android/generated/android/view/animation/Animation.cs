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
			internal static global::MonoJavaBridge.MethodId _onAnimationStart9900;
			 void android.view.animation.Animation.AnimationListener.onAnimationStart(android.view.animation.Animation arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_._onAnimationStart9900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_.staticClass, global::android.view.animation.Animation.AnimationListener_._onAnimationStart9900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationEnd9901;
			 void android.view.animation.Animation.AnimationListener.onAnimationEnd(android.view.animation.Animation arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_._onAnimationEnd9901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_.staticClass, global::android.view.animation.Animation.AnimationListener_._onAnimationEnd9901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationRepeat9902;
			 void android.view.animation.Animation.AnimationListener.onAnimationRepeat(android.view.animation.Animation arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat9902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.AnimationListener_.staticClass, global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat9902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.Animation.AnimationListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation$AnimationListener"));
				global::android.view.animation.Animation.AnimationListener_._onAnimationStart9900 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationStart", "(Landroid/view/animation/Animation;)V");
				global::android.view.animation.Animation.AnimationListener_._onAnimationEnd9901 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationEnd", "(Landroid/view/animation/Animation;)V");
				global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat9902 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationRepeat", "(Landroid/view/animation/Animation;)V");
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
			internal static global::MonoJavaBridge.MethodId _Description9903;
			protected Description()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.Description.staticClass, global::android.view.animation.Animation.Description._Description9903);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _type9904;
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
			internal static global::MonoJavaBridge.FieldId _value9905;
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
				global::android.view.animation.Animation.Description._Description9903 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _clone9906;
		protected virtual new global::android.view.animation.Animation clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Animation._clone9906)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._clone9906)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _start9907;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._start9907);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._start9907);
		}
		internal static global::MonoJavaBridge.MethodId _reset9908;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._reset9908);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._reset9908);
		}
		internal static global::MonoJavaBridge.MethodId _initialize9909;
		public virtual void initialize(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._initialize9909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._initialize9909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cancel9910;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._cancel9910);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._cancel9910);
		}
		internal static global::MonoJavaBridge.MethodId _resolveSize9911;
		protected virtual float resolveSize(int arg0, float arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.Animation._resolveSize9911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._resolveSize9911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getRepeatCount9912;
		public virtual int getRepeatCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Animation._getRepeatCount9912);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getRepeatCount9912);
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator9913;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setInterpolator9913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setInterpolator9913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator9914;
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setInterpolator9914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setInterpolator9914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolator9915;
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Animation._getInterpolator9915)) as android.view.animation.Interpolator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getInterpolator9915)) as android.view.animation.Interpolator;
		}
		internal static global::MonoJavaBridge.MethodId _isInitialized9916;
		public virtual bool isInitialized() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._isInitialized9916);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._isInitialized9916);
		}
		internal static global::MonoJavaBridge.MethodId _setStartOffset9917;
		public virtual void setStartOffset(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setStartOffset9917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setStartOffset9917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDuration9918;
		public virtual void setDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setDuration9918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setDuration9918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restrictDuration9919;
		public virtual void restrictDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._restrictDuration9919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._restrictDuration9919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scaleCurrentDuration9920;
		public virtual void scaleCurrentDuration(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._scaleCurrentDuration9920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._scaleCurrentDuration9920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStartTime9921;
		public virtual void setStartTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setStartTime9921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setStartTime9921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startNow9922;
		public virtual void startNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._startNow9922);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._startNow9922);
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatMode9923;
		public virtual void setRepeatMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setRepeatMode9923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setRepeatMode9923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatCount9924;
		public virtual void setRepeatCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setRepeatCount9924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setRepeatCount9924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFillEnabled9925;
		public virtual bool isFillEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._isFillEnabled9925);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._isFillEnabled9925);
		}
		internal static global::MonoJavaBridge.MethodId _setFillEnabled9926;
		public virtual void setFillEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setFillEnabled9926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillEnabled9926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillBefore9927;
		public virtual void setFillBefore(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setFillBefore9927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillBefore9927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillAfter9928;
		public virtual void setFillAfter(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setFillAfter9928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setFillAfter9928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZAdjustment9929;
		public virtual void setZAdjustment(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setZAdjustment9929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setZAdjustment9929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDetachWallpaper9930;
		public virtual void setDetachWallpaper(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setDetachWallpaper9930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setDetachWallpaper9930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStartTime9931;
		public virtual long getStartTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._getStartTime9931);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getStartTime9931);
		}
		internal static global::MonoJavaBridge.MethodId _getDuration9932;
		public virtual long getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._getDuration9932);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getDuration9932);
		}
		internal static global::MonoJavaBridge.MethodId _getStartOffset9933;
		public virtual long getStartOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._getStartOffset9933);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getStartOffset9933);
		}
		internal static global::MonoJavaBridge.MethodId _getRepeatMode9934;
		public virtual int getRepeatMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Animation._getRepeatMode9934);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getRepeatMode9934);
		}
		internal static global::MonoJavaBridge.MethodId _getFillBefore9935;
		public virtual bool getFillBefore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getFillBefore9935);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getFillBefore9935);
		}
		internal static global::MonoJavaBridge.MethodId _getFillAfter9936;
		public virtual bool getFillAfter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getFillAfter9936);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getFillAfter9936);
		}
		internal static global::MonoJavaBridge.MethodId _getZAdjustment9937;
		public virtual int getZAdjustment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Animation._getZAdjustment9937);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getZAdjustment9937);
		}
		internal static global::MonoJavaBridge.MethodId _getDetachWallpaper9938;
		public virtual bool getDetachWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getDetachWallpaper9938);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getDetachWallpaper9938);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeTransformationMatrix9939;
		public virtual bool willChangeTransformationMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._willChangeTransformationMatrix9939);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._willChangeTransformationMatrix9939);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeBounds9940;
		public virtual bool willChangeBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._willChangeBounds9940);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._willChangeBounds9940);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationListener9941;
		public virtual void setAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._setAnimationListener9941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._setAnimationListener9941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ensureInterpolator9942;
		protected virtual void ensureInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._ensureInterpolator9942);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._ensureInterpolator9942);
		}
		internal static global::MonoJavaBridge.MethodId _computeDurationHint9943;
		public virtual long computeDurationHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.Animation._computeDurationHint9943);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._computeDurationHint9943);
		}
		internal static global::MonoJavaBridge.MethodId _getTransformation9944;
		public virtual bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._getTransformation9944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._getTransformation9944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasStarted9945;
		public virtual bool hasStarted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._hasStarted9945);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._hasStarted9945);
		}
		internal static global::MonoJavaBridge.MethodId _hasEnded9946;
		public virtual bool hasEnded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.Animation._hasEnded9946);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._hasEnded9946);
		}
		internal static global::MonoJavaBridge.MethodId _applyTransformation9947;
		protected virtual void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Animation._applyTransformation9947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Animation.staticClass, global::android.view.animation.Animation._applyTransformation9947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Animation9948;
		public Animation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation9948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Animation9949;
		public Animation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation9949);
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
			global::android.view.animation.Animation._clone9906 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "clone", "()Landroid/view/animation/Animation;");
			global::android.view.animation.Animation._start9907 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "start", "()V");
			global::android.view.animation.Animation._reset9908 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "reset", "()V");
			global::android.view.animation.Animation._initialize9909 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.Animation._cancel9910 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "cancel", "()V");
			global::android.view.animation.Animation._resolveSize9911 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "resolveSize", "(IFII)F");
			global::android.view.animation.Animation._getRepeatCount9912 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getRepeatCount", "()I");
			global::android.view.animation.Animation._setInterpolator9913 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.view.animation.Animation._setInterpolator9914 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.view.animation.Animation._getInterpolator9915 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.view.animation.Animation._isInitialized9916 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "isInitialized", "()Z");
			global::android.view.animation.Animation._setStartOffset9917 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setStartOffset", "(J)V");
			global::android.view.animation.Animation._setDuration9918 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setDuration", "(J)V");
			global::android.view.animation.Animation._restrictDuration9919 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "restrictDuration", "(J)V");
			global::android.view.animation.Animation._scaleCurrentDuration9920 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "scaleCurrentDuration", "(F)V");
			global::android.view.animation.Animation._setStartTime9921 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setStartTime", "(J)V");
			global::android.view.animation.Animation._startNow9922 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "startNow", "()V");
			global::android.view.animation.Animation._setRepeatMode9923 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setRepeatMode", "(I)V");
			global::android.view.animation.Animation._setRepeatCount9924 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setRepeatCount", "(I)V");
			global::android.view.animation.Animation._isFillEnabled9925 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "isFillEnabled", "()Z");
			global::android.view.animation.Animation._setFillEnabled9926 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setFillEnabled", "(Z)V");
			global::android.view.animation.Animation._setFillBefore9927 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setFillBefore", "(Z)V");
			global::android.view.animation.Animation._setFillAfter9928 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setFillAfter", "(Z)V");
			global::android.view.animation.Animation._setZAdjustment9929 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setZAdjustment", "(I)V");
			global::android.view.animation.Animation._setDetachWallpaper9930 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setDetachWallpaper", "(Z)V");
			global::android.view.animation.Animation._getStartTime9931 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getStartTime", "()J");
			global::android.view.animation.Animation._getDuration9932 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getDuration", "()J");
			global::android.view.animation.Animation._getStartOffset9933 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getStartOffset", "()J");
			global::android.view.animation.Animation._getRepeatMode9934 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getRepeatMode", "()I");
			global::android.view.animation.Animation._getFillBefore9935 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getFillBefore", "()Z");
			global::android.view.animation.Animation._getFillAfter9936 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getFillAfter", "()Z");
			global::android.view.animation.Animation._getZAdjustment9937 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getZAdjustment", "()I");
			global::android.view.animation.Animation._getDetachWallpaper9938 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getDetachWallpaper", "()Z");
			global::android.view.animation.Animation._willChangeTransformationMatrix9939 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "willChangeTransformationMatrix", "()Z");
			global::android.view.animation.Animation._willChangeBounds9940 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "willChangeBounds", "()Z");
			global::android.view.animation.Animation._setAnimationListener9941 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V");
			global::android.view.animation.Animation._ensureInterpolator9942 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "ensureInterpolator", "()V");
			global::android.view.animation.Animation._computeDurationHint9943 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "computeDurationHint", "()J");
			global::android.view.animation.Animation._getTransformation9944 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z");
			global::android.view.animation.Animation._hasStarted9945 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "hasStarted", "()Z");
			global::android.view.animation.Animation._hasEnded9946 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "hasEnded", "()Z");
			global::android.view.animation.Animation._applyTransformation9947 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V");
			global::android.view.animation.Animation._Animation9948 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.Animation._Animation9949 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "<init>", "()V");
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
