namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LayoutAnimationController : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LayoutAnimationController()
		{
			InitJNI();
		}
		protected LayoutAnimationController(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AnimationParameters : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AnimationParameters()
			{
				InitJNI();
			}
			protected AnimationParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _AnimationParameters10017;
			public AnimationParameters()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, global::android.view.animation.LayoutAnimationController.AnimationParameters._AnimationParameters10017);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _count10018;
			public int count
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _index10019;
			public int index
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/LayoutAnimationController$AnimationParameters"));
				global::android.view.animation.LayoutAnimationController.AnimationParameters._AnimationParameters10017 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _start10020;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._start10020);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._start10020);
		}
		internal static global::MonoJavaBridge.MethodId _getAnimation10021;
		public virtual global::android.view.animation.Animation getAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getAnimation10021)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getAnimation10021)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _setAnimation10022;
		public virtual void setAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setAnimation10022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setAnimation10022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAnimation10023;
		public virtual void setAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setAnimation10023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setAnimation10023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOrder10024;
		public virtual int getOrder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getOrder10024);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getOrder10024);
		}
		internal static global::MonoJavaBridge.MethodId _isDone10025;
		public virtual bool isDone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._isDone10025);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._isDone10025);
		}
		internal static global::MonoJavaBridge.MethodId _setOrder10026;
		public virtual void setOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setOrder10026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setOrder10026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator10027;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setInterpolator10027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setInterpolator10027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator10028;
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setInterpolator10028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setInterpolator10028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolator10029;
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getInterpolator10029)) as android.view.animation.Interpolator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getInterpolator10029)) as android.view.animation.Interpolator;
		}
		internal static global::MonoJavaBridge.MethodId _getDelay10030;
		public virtual float getDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getDelay10030);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getDelay10030);
		}
		internal static global::MonoJavaBridge.MethodId _setDelay10031;
		public virtual void setDelay(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setDelay10031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setDelay10031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _willOverlap10032;
		public virtual bool willOverlap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._willOverlap10032);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._willOverlap10032);
		}
		internal static global::MonoJavaBridge.MethodId _getAnimationForView10033;
		public virtual global::android.view.animation.Animation getAnimationForView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getAnimationForView10033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getAnimationForView10033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _getDelayForView10034;
		protected virtual long getDelayForView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getDelayForView10034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getDelayForView10034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransformedIndex10035;
		protected virtual int getTransformedIndex(android.view.animation.LayoutAnimationController.AnimationParameters arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getTransformedIndex10035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getTransformedIndex10035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LayoutAnimationController10036;
		public LayoutAnimationController(android.view.animation.Animation arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController10036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LayoutAnimationController10037;
		public LayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController10037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LayoutAnimationController10038;
		public LayoutAnimationController(android.view.animation.Animation arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController10038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int ORDER_NORMAL
		{
			get
			{
				return 0;
			}
		}
		public static int ORDER_REVERSE
		{
			get
			{
				return 1;
			}
		}
		public static int ORDER_RANDOM
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.LayoutAnimationController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/LayoutAnimationController"));
			global::android.view.animation.LayoutAnimationController._start10020 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "start", "()V");
			global::android.view.animation.LayoutAnimationController._getAnimation10021 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getAnimation", "()Landroid/view/animation/Animation;");
			global::android.view.animation.LayoutAnimationController._setAnimation10022 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/content/Context;I)V");
			global::android.view.animation.LayoutAnimationController._setAnimation10023 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.LayoutAnimationController._getOrder10024 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getOrder", "()I");
			global::android.view.animation.LayoutAnimationController._isDone10025 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "isDone", "()Z");
			global::android.view.animation.LayoutAnimationController._setOrder10026 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setOrder", "(I)V");
			global::android.view.animation.LayoutAnimationController._setInterpolator10027 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.view.animation.LayoutAnimationController._setInterpolator10028 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.view.animation.LayoutAnimationController._getInterpolator10029 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.view.animation.LayoutAnimationController._getDelay10030 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getDelay", "()F");
			global::android.view.animation.LayoutAnimationController._setDelay10031 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setDelay", "(F)V");
			global::android.view.animation.LayoutAnimationController._willOverlap10032 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "willOverlap", "()Z");
			global::android.view.animation.LayoutAnimationController._getAnimationForView10033 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getAnimationForView", "(Landroid/view/View;)Landroid/view/animation/Animation;");
			global::android.view.animation.LayoutAnimationController._getDelayForView10034 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J");
			global::android.view.animation.LayoutAnimationController._getTransformedIndex10035 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getTransformedIndex", "(Landroid/view/animation/LayoutAnimationController$AnimationParameters;)I");
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController10036 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;F)V");
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController10037 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController10038 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V");
		}
	}
}
