namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GridLayoutAnimationController : android.view.animation.LayoutAnimationController
	{ 
		internal new static global::java.lang.Class staticClass; 
		static GridLayoutAnimationController() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.animation.GridLayoutAnimationController), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.animation.GridLayoutAnimationController(@__env); 
			} 
		} 
		protected GridLayoutAnimationController(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public new class AnimationParameters : android.view.animation.LayoutAnimationController.AnimationParameters
		{ 
			internal new static global::java.lang.Class staticClass; 
			static AnimationParameters() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.animation.GridLayoutAnimationController.AnimationParameters), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.animation.GridLayoutAnimationController.AnimationParameters(@__env); 
				} 
			} 
			protected AnimationParameters(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _AnimationParameters8302; 
			public AnimationParameters()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, _AnimationParameters8302, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _column8303; 
			public int column
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _row8304; 
			public int row
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _columnsCount8305; 
			public int columnsCount
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _rowsCount8306; 
			public int rowsCount
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
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass = @__class; 
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._AnimationParameters8302 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willOverlap8307; 
		public override bool willOverlap() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.GridLayoutAnimationController)) 
				return @__env.CallBooleanMethod(this, _willOverlap8307); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.GridLayoutAnimationController.staticClass, _willOverlap8307); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDelayForView8308; 
		protected override long getDelayForView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.GridLayoutAnimationController)) 
				return @__env.CallLongMethod(this, _getDelayForView8308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.animation.GridLayoutAnimationController.staticClass, _getDelayForView8308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnDelay8309; 
		public virtual float getColumnDelay() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.GridLayoutAnimationController)) 
				return @__env.CallFloatMethod(this, _getColumnDelay8309); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.animation.GridLayoutAnimationController.staticClass, _getColumnDelay8309); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColumnDelay8310; 
		public virtual void setColumnDelay(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.GridLayoutAnimationController)) 
				@__env.CallVoidMethod(this, _setColumnDelay8310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.GridLayoutAnimationController.staticClass, _setColumnDelay8310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRowDelay8311; 
		public virtual float getRowDelay() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.GridLayoutAnimationController)) 
				return @__env.CallFloatMethod(this, _getRowDelay8311); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.animation.GridLayoutAnimationController.staticClass, _getRowDelay8311); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRowDelay8312; 
		public virtual void setRowDelay(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.GridLayoutAnimationController)) 
				@__env.CallVoidMethod(this, _setRowDelay8312, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.GridLayoutAnimationController.staticClass, _setRowDelay8312, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDirection8313; 
		public virtual int getDirection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.GridLayoutAnimationController)) 
				return @__env.CallIntMethod(this, _getDirection8313); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.animation.GridLayoutAnimationController.staticClass, _getDirection8313); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDirection8314; 
		public virtual void setDirection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.GridLayoutAnimationController)) 
				@__env.CallVoidMethod(this, _setDirection8314, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.GridLayoutAnimationController.staticClass, _setDirection8314, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDirectionPriority8315; 
		public virtual int getDirectionPriority() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.GridLayoutAnimationController)) 
				return @__env.CallIntMethod(this, _getDirectionPriority8315); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.animation.GridLayoutAnimationController.staticClass, _getDirectionPriority8315); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDirectionPriority8316; 
		public virtual void setDirectionPriority(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.GridLayoutAnimationController)) 
				@__env.CallVoidMethod(this, _setDirectionPriority8316, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.GridLayoutAnimationController.staticClass, _setDirectionPriority8316, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GridLayoutAnimationController8317; 
		public GridLayoutAnimationController(android.view.animation.Animation arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, _GridLayoutAnimationController8317, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GridLayoutAnimationController8318; 
		public GridLayoutAnimationController(android.view.animation.Animation arg0, float arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, _GridLayoutAnimationController8318, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GridLayoutAnimationController8319; 
		public GridLayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, _GridLayoutAnimationController8319, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		public static int DIRECTION_LEFT_TO_RIGHT
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int DIRECTION_RIGHT_TO_LEFT
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int DIRECTION_TOP_TO_BOTTOM
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int DIRECTION_BOTTOM_TO_TOP
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int DIRECTION_HORIZONTAL_MASK
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int DIRECTION_VERTICAL_MASK
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int PRIORITY_NONE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int PRIORITY_COLUMN
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int PRIORITY_ROW
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.GridLayoutAnimationController.staticClass = @__class; 
			global::android.view.animation.GridLayoutAnimationController._willOverlap8307 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "willOverlap", "()Z"); 
			global::android.view.animation.GridLayoutAnimationController._getDelayForView8308 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J"); 
			global::android.view.animation.GridLayoutAnimationController._getColumnDelay8309 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "getColumnDelay", "()F"); 
			global::android.view.animation.GridLayoutAnimationController._setColumnDelay8310 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "setColumnDelay", "(F)V"); 
			global::android.view.animation.GridLayoutAnimationController._getRowDelay8311 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "getRowDelay", "()F"); 
			global::android.view.animation.GridLayoutAnimationController._setRowDelay8312 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "setRowDelay", "(F)V"); 
			global::android.view.animation.GridLayoutAnimationController._getDirection8313 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirection", "()I"); 
			global::android.view.animation.GridLayoutAnimationController._setDirection8314 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirection", "(I)V"); 
			global::android.view.animation.GridLayoutAnimationController._getDirectionPriority8315 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirectionPriority", "()I"); 
			global::android.view.animation.GridLayoutAnimationController._setDirectionPriority8316 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirectionPriority", "(I)V"); 
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController8317 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V"); 
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController8318 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;FF)V"); 
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController8319 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
