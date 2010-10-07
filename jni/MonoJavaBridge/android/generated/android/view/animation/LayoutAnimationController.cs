namespace android.view.animation
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class LayoutAnimationController : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static LayoutAnimationController()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.LayoutAnimationController), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.animation.LayoutAnimationController(@__env);
			}
		}
		protected LayoutAnimationController(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class AnimationParameters : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static AnimationParameters()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.LayoutAnimationController.AnimationParameters), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.animation.LayoutAnimationController.AnimationParameters(@__env);
				}
			}
			protected AnimationParameters(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _AnimationParameters9670;
			public AnimationParameters()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, global::android.view.animation.LayoutAnimationController.AnimationParameters._AnimationParameters9670, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _count9671;
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
			internal static global::net.sf.jni4net.jni.FieldId _index9672;
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass = @__class;
				global::android.view.animation.LayoutAnimationController.AnimationParameters._AnimationParameters9670 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _start9673;
		public virtual void start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController._start9673);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._start9673);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAnimation9674;
		public virtual global::android.view.animation.Animation getAnimation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.LayoutAnimationController._getAnimation9674));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getAnimation9674));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAnimation9675;
		public virtual void setAnimation(android.content.Context arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController._setAnimation9675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setAnimation9675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAnimation9676;
		public virtual void setAnimation(android.view.animation.Animation arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController._setAnimation9676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setAnimation9676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOrder9677;
		public virtual int getOrder() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.animation.LayoutAnimationController._getOrder9677);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getOrder9677);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDone9678;
		public virtual bool isDone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.LayoutAnimationController._isDone9678);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._isDone9678);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOrder9679;
		public virtual void setOrder(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController._setOrder9679, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setOrder9679, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator9680;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController._setInterpolator9680, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setInterpolator9680, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator9681;
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController._setInterpolator9681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setInterpolator9681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolator9682;
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.LayoutAnimationController._getInterpolator9682));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getInterpolator9682));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDelay9683;
		public virtual float getDelay() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.animation.LayoutAnimationController._getDelay9683);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getDelay9683);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDelay9684;
		public virtual void setDelay(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController._setDelay9684, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._setDelay9684, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _willOverlap9685;
		public virtual bool willOverlap() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.LayoutAnimationController._willOverlap9685);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._willOverlap9685);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAnimationForView9686;
		public virtual global::android.view.animation.Animation getAnimationForView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.LayoutAnimationController._getAnimationForView9686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getAnimationForView9686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDelayForView9687;
		protected virtual long getDelayForView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.animation.LayoutAnimationController._getDelayForView9687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getDelayForView9687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTransformedIndex9688;
		protected virtual int getTransformedIndex(android.view.animation.LayoutAnimationController.AnimationParameters arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.animation.LayoutAnimationController._getTransformedIndex9688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._getTransformedIndex9688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LayoutAnimationController9689;
		public LayoutAnimationController(android.view.animation.Animation arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController9689, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LayoutAnimationController9690;
		public LayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController9690, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LayoutAnimationController9691;
		public LayoutAnimationController(android.view.animation.Animation arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController9691, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.animation.LayoutAnimationController.staticClass = @__class;
			global::android.view.animation.LayoutAnimationController._start9673 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "start", "()V");
			global::android.view.animation.LayoutAnimationController._getAnimation9674 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getAnimation", "()Landroid/view/animation/Animation;");
			global::android.view.animation.LayoutAnimationController._setAnimation9675 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/content/Context;I)V");
			global::android.view.animation.LayoutAnimationController._setAnimation9676 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.LayoutAnimationController._getOrder9677 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getOrder", "()I");
			global::android.view.animation.LayoutAnimationController._isDone9678 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "isDone", "()Z");
			global::android.view.animation.LayoutAnimationController._setOrder9679 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "setOrder", "(I)V");
			global::android.view.animation.LayoutAnimationController._setInterpolator9680 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.view.animation.LayoutAnimationController._setInterpolator9681 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.view.animation.LayoutAnimationController._getInterpolator9682 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.view.animation.LayoutAnimationController._getDelay9683 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getDelay", "()F");
			global::android.view.animation.LayoutAnimationController._setDelay9684 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "setDelay", "(F)V");
			global::android.view.animation.LayoutAnimationController._willOverlap9685 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "willOverlap", "()Z");
			global::android.view.animation.LayoutAnimationController._getAnimationForView9686 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getAnimationForView", "(Landroid/view/View;)Landroid/view/animation/Animation;");
			global::android.view.animation.LayoutAnimationController._getDelayForView9687 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J");
			global::android.view.animation.LayoutAnimationController._getTransformedIndex9688 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getTransformedIndex", "(Landroid/view/animation/LayoutAnimationController$AnimationParameters;)I");
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController9689 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;F)V");
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController9690 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController9691 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V");
		}
	}
}
