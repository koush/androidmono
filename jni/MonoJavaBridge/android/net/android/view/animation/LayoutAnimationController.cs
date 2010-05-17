namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LayoutAnimationController : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static LayoutAnimationController() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.animation.LayoutAnimationController), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.animation.LayoutAnimationController.AnimationParameters), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _AnimationParameters8320; 
			public AnimationParameters()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, _AnimationParameters8320, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _count8321; 
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
			internal static global::net.sf.jni4net.jni.FieldId _index8322; 
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
				global::android.view.animation.LayoutAnimationController.AnimationParameters._AnimationParameters8320 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start8323; 
		public virtual void start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				@__env.CallVoidMethod(this, _start8323); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.LayoutAnimationController.staticClass, _start8323); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAnimation8324; 
		public virtual android.view.animation.Animation getAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, _getAnimation8324)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.animation.LayoutAnimationController.staticClass, _getAnimation8324)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimation8325; 
		public virtual void setAnimation(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				@__env.CallVoidMethod(this, _setAnimation8325, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.LayoutAnimationController.staticClass, _setAnimation8325, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimation8326; 
		public virtual void setAnimation(android.view.animation.Animation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				@__env.CallVoidMethod(this, _setAnimation8326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.LayoutAnimationController.staticClass, _setAnimation8326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrder8327; 
		public virtual int getOrder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				return @__env.CallIntMethod(this, _getOrder8327); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.animation.LayoutAnimationController.staticClass, _getOrder8327); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDone8328; 
		public virtual bool isDone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				return @__env.CallBooleanMethod(this, _isDone8328); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.LayoutAnimationController.staticClass, _isDone8328); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrder8329; 
		public virtual void setOrder(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				@__env.CallVoidMethod(this, _setOrder8329, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.LayoutAnimationController.staticClass, _setOrder8329, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator8330; 
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				@__env.CallVoidMethod(this, _setInterpolator8330, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.LayoutAnimationController.staticClass, _setInterpolator8330, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator8331; 
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				@__env.CallVoidMethod(this, _setInterpolator8331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.LayoutAnimationController.staticClass, _setInterpolator8331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolator8332; 
		public virtual android.view.animation.Interpolator getInterpolator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallObjectMethodPtr(this, _getInterpolator8332)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.animation.LayoutAnimationController.staticClass, _getInterpolator8332)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDelay8333; 
		public virtual float getDelay() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				return @__env.CallFloatMethod(this, _getDelay8333); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.animation.LayoutAnimationController.staticClass, _getDelay8333); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDelay8334; 
		public virtual void setDelay(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				@__env.CallVoidMethod(this, _setDelay8334, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.LayoutAnimationController.staticClass, _setDelay8334, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willOverlap8335; 
		public virtual bool willOverlap() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				return @__env.CallBooleanMethod(this, _willOverlap8335); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.LayoutAnimationController.staticClass, _willOverlap8335); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAnimationForView8336; 
		public virtual android.view.animation.Animation getAnimationForView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, _getAnimationForView8336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.animation.LayoutAnimationController.staticClass, _getAnimationForView8336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDelayForView8337; 
		protected virtual long getDelayForView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				return @__env.CallLongMethod(this, _getDelayForView8337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.animation.LayoutAnimationController.staticClass, _getDelayForView8337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransformedIndex8338; 
		protected virtual int getTransformedIndex(android.view.animation.LayoutAnimationController.AnimationParameters arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LayoutAnimationController)) 
				return @__env.CallIntMethod(this, _getTransformedIndex8338, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.animation.LayoutAnimationController.staticClass, _getTransformedIndex8338, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LayoutAnimationController8339; 
		public LayoutAnimationController(android.view.animation.Animation arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, _LayoutAnimationController8339, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LayoutAnimationController8340; 
		public LayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, _LayoutAnimationController8340, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LayoutAnimationController8341; 
		public LayoutAnimationController(android.view.animation.Animation arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, _LayoutAnimationController8341, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			global::android.view.animation.LayoutAnimationController._start8323 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "start", "()V"); 
			global::android.view.animation.LayoutAnimationController._getAnimation8324 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getAnimation", "()Landroid/view/animation/Animation;"); 
			global::android.view.animation.LayoutAnimationController._setAnimation8325 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/content/Context;I)V"); 
			global::android.view.animation.LayoutAnimationController._setAnimation8326 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V"); 
			global::android.view.animation.LayoutAnimationController._getOrder8327 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getOrder", "()I"); 
			global::android.view.animation.LayoutAnimationController._isDone8328 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "isDone", "()Z"); 
			global::android.view.animation.LayoutAnimationController._setOrder8329 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "setOrder", "(I)V"); 
			global::android.view.animation.LayoutAnimationController._setInterpolator8330 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V"); 
			global::android.view.animation.LayoutAnimationController._setInterpolator8331 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/content/Context;I)V"); 
			global::android.view.animation.LayoutAnimationController._getInterpolator8332 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;"); 
			global::android.view.animation.LayoutAnimationController._getDelay8333 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getDelay", "()F"); 
			global::android.view.animation.LayoutAnimationController._setDelay8334 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "setDelay", "(F)V"); 
			global::android.view.animation.LayoutAnimationController._willOverlap8335 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "willOverlap", "()Z"); 
			global::android.view.animation.LayoutAnimationController._getAnimationForView8336 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getAnimationForView", "(Landroid/view/View;)Landroid/view/animation/Animation;"); 
			global::android.view.animation.LayoutAnimationController._getDelayForView8337 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J"); 
			global::android.view.animation.LayoutAnimationController._getTransformedIndex8338 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "getTransformedIndex", "(Landroid/view/animation/LayoutAnimationController$AnimationParameters;)I"); 
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController8339 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;F)V"); 
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController8340 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.view.animation.LayoutAnimationController._LayoutAnimationController8341 = @__env.GetMethodID(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V"); 
		} 
	} 
} 
