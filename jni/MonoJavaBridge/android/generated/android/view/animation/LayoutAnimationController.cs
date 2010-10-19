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
			internal static global::MonoJavaBridge.MethodId _AnimationParameters10563;
			public AnimationParameters()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, global::android.view.animation.LayoutAnimationController.AnimationParameters._AnimationParameters10563);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _count10564;
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
			internal static global::MonoJavaBridge.FieldId _index10565;
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
				global::android.view.animation.LayoutAnimationController.AnimationParameters._AnimationParameters10563 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _start10566;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._start10566);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._start10566);
		}
		public new global::android.view.animation.Animation Animation
		{
			get
			{
				return getAnimation();
			}
			set
			{
				setAnimation(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnimation10567;
		public virtual global::android.view.animation.Animation getAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getAnimation10567)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getAnimation10567)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _setAnimation10568;
		public virtual void setAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setAnimation10568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setAnimation10568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAnimation10569;
		public virtual void setAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setAnimation10569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setAnimation10569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Order
		{
			get
			{
				return getOrder();
			}
			set
			{
				setOrder(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOrder10570;
		public virtual int getOrder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getOrder10570);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getOrder10570);
		}
		internal static global::MonoJavaBridge.MethodId _isDone10571;
		public virtual bool isDone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._isDone10571);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._isDone10571);
		}
		internal static global::MonoJavaBridge.MethodId _setOrder10572;
		public virtual void setOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setOrder10572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setOrder10572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator10573;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setInterpolator10573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setInterpolator10573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator10574;
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setInterpolator10574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setInterpolator10574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.animation.Interpolator Interpolator
		{
			get
			{
				return getInterpolator();
			}
			set
			{
				setInterpolator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolator10575;
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getInterpolator10575)) as android.view.animation.Interpolator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getInterpolator10575)) as android.view.animation.Interpolator;
		}
		public new float Delay
		{
			get
			{
				return getDelay();
			}
			set
			{
				setDelay(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDelay10576;
		public virtual float getDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getDelay10576);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getDelay10576);
		}
		internal static global::MonoJavaBridge.MethodId _setDelay10577;
		public virtual void setDelay(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setDelay10577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setDelay10577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _willOverlap10578;
		public virtual bool willOverlap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._willOverlap10578);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._willOverlap10578);
		}
		internal static global::MonoJavaBridge.MethodId _getAnimationForView10579;
		public virtual global::android.view.animation.Animation getAnimationForView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getAnimationForView10579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getAnimationForView10579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _getDelayForView10580;
		protected virtual long getDelayForView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getDelayForView10580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getDelayForView10580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransformedIndex10581;
		protected virtual int getTransformedIndex(android.view.animation.LayoutAnimationController.AnimationParameters arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getTransformedIndex10581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getTransformedIndex10581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LayoutAnimationController10582;
		public LayoutAnimationController(android.view.animation.Animation arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController10582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LayoutAnimationController10583;
		public LayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController10583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LayoutAnimationController10584;
		public LayoutAnimationController(android.view.animation.Animation arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController10584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.view.animation.LayoutAnimationController._start10566 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "start", "()V");
			global::android.view.animation.LayoutAnimationController._getAnimation10567 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getAnimation", "()Landroid/view/animation/Animation;");
			global::android.view.animation.LayoutAnimationController._setAnimation10568 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/content/Context;I)V");
			global::android.view.animation.LayoutAnimationController._setAnimation10569 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.LayoutAnimationController._getOrder10570 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getOrder", "()I");
			global::android.view.animation.LayoutAnimationController._isDone10571 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "isDone", "()Z");
			global::android.view.animation.LayoutAnimationController._setOrder10572 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setOrder", "(I)V");
			global::android.view.animation.LayoutAnimationController._setInterpolator10573 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.view.animation.LayoutAnimationController._setInterpolator10574 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.view.animation.LayoutAnimationController._getInterpolator10575 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.view.animation.LayoutAnimationController._getDelay10576 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getDelay", "()F");
			global::android.view.animation.LayoutAnimationController._setDelay10577 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setDelay", "(F)V");
			global::android.view.animation.LayoutAnimationController._willOverlap10578 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "willOverlap", "()Z");
			global::android.view.animation.LayoutAnimationController._getAnimationForView10579 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getAnimationForView", "(Landroid/view/View;)Landroid/view/animation/Animation;");
			global::android.view.animation.LayoutAnimationController._getDelayForView10580 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J");
			global::android.view.animation.LayoutAnimationController._getTransformedIndex10581 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getTransformedIndex", "(Landroid/view/animation/LayoutAnimationController$AnimationParameters;)I");
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController10582 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;F)V");
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController10583 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController10584 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V");
		}
	}
}
