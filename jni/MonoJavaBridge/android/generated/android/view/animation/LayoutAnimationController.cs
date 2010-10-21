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
			internal static global::MonoJavaBridge.MethodId _AnimationParameters15631;
			public AnimationParameters()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, global::android.view.animation.LayoutAnimationController.AnimationParameters._AnimationParameters15631);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _count15632;
			public int count
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _count15632);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _index15633;
			public int index
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _index15633);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/LayoutAnimationController$AnimationParameters"));
				global::android.view.animation.LayoutAnimationController.AnimationParameters._AnimationParameters15631 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V");
				global::android.view.animation.LayoutAnimationController.AnimationParameters._count15632 = @__env.GetFieldIDNoThrow(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "count", "I");
				global::android.view.animation.LayoutAnimationController.AnimationParameters._index15633 = @__env.GetFieldIDNoThrow(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "index", "I");
			}
		}
		internal static global::MonoJavaBridge.MethodId _start15634;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._start15634);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._start15634);
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
		internal static global::MonoJavaBridge.MethodId _getAnimation15635;
		public virtual global::android.view.animation.Animation getAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getAnimation15635)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getAnimation15635)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _setAnimation15636;
		public virtual void setAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setAnimation15636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setAnimation15636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAnimation15637;
		public virtual void setAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setAnimation15637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setAnimation15637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOrder15638;
		public virtual int getOrder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getOrder15638);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getOrder15638);
		}
		internal static global::MonoJavaBridge.MethodId _isDone15639;
		public virtual bool isDone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._isDone15639);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._isDone15639);
		}
		internal static global::MonoJavaBridge.MethodId _setOrder15640;
		public virtual void setOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setOrder15640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setOrder15640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator15641;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setInterpolator15641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setInterpolator15641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator15642;
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setInterpolator15642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setInterpolator15642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getInterpolator15643;
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getInterpolator15643)) as android.view.animation.Interpolator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getInterpolator15643)) as android.view.animation.Interpolator;
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
		internal static global::MonoJavaBridge.MethodId _getDelay15644;
		public virtual float getDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getDelay15644);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getDelay15644);
		}
		internal static global::MonoJavaBridge.MethodId _setDelay15645;
		public virtual void setDelay(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._setDelay15645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setDelay15645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _willOverlap15646;
		public virtual bool willOverlap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._willOverlap15646);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._willOverlap15646);
		}
		internal static global::MonoJavaBridge.MethodId _getAnimationForView15647;
		public virtual global::android.view.animation.Animation getAnimationForView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getAnimationForView15647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getAnimationForView15647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _getDelayForView15648;
		protected virtual long getDelayForView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getDelayForView15648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getDelayForView15648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransformedIndex15649;
		protected virtual int getTransformedIndex(android.view.animation.LayoutAnimationController.AnimationParameters arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController._getTransformedIndex15649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getTransformedIndex15649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LayoutAnimationController15650;
		public LayoutAnimationController(android.view.animation.Animation arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController15650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LayoutAnimationController15651;
		public LayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController15651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LayoutAnimationController15652;
		public LayoutAnimationController(android.view.animation.Animation arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController15652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.view.animation.LayoutAnimationController._start15634 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "start", "()V");
			global::android.view.animation.LayoutAnimationController._getAnimation15635 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getAnimation", "()Landroid/view/animation/Animation;");
			global::android.view.animation.LayoutAnimationController._setAnimation15636 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/content/Context;I)V");
			global::android.view.animation.LayoutAnimationController._setAnimation15637 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.LayoutAnimationController._getOrder15638 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getOrder", "()I");
			global::android.view.animation.LayoutAnimationController._isDone15639 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "isDone", "()Z");
			global::android.view.animation.LayoutAnimationController._setOrder15640 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setOrder", "(I)V");
			global::android.view.animation.LayoutAnimationController._setInterpolator15641 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.view.animation.LayoutAnimationController._setInterpolator15642 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.view.animation.LayoutAnimationController._getInterpolator15643 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.view.animation.LayoutAnimationController._getDelay15644 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getDelay", "()F");
			global::android.view.animation.LayoutAnimationController._setDelay15645 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "setDelay", "(F)V");
			global::android.view.animation.LayoutAnimationController._willOverlap15646 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "willOverlap", "()Z");
			global::android.view.animation.LayoutAnimationController._getAnimationForView15647 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getAnimationForView", "(Landroid/view/View;)Landroid/view/animation/Animation;");
			global::android.view.animation.LayoutAnimationController._getDelayForView15648 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J");
			global::android.view.animation.LayoutAnimationController._getTransformedIndex15649 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "getTransformedIndex", "(Landroid/view/animation/LayoutAnimationController$AnimationParameters;)I");
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController15650 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;F)V");
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController15651 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController15652 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V");
		}
	}
}
