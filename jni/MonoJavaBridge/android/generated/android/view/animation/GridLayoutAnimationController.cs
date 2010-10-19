namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GridLayoutAnimationController : android.view.animation.LayoutAnimationController
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GridLayoutAnimationController()
		{
			InitJNI();
		}
		protected GridLayoutAnimationController(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class AnimationParameters : android.view.animation.LayoutAnimationController.AnimationParameters
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AnimationParameters()
			{
				InitJNI();
			}
			protected AnimationParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _AnimationParameters10544;
			public AnimationParameters()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, global::android.view.animation.GridLayoutAnimationController.AnimationParameters._AnimationParameters10544);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _column10545;
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
			internal static global::MonoJavaBridge.FieldId _row10546;
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
			internal static global::MonoJavaBridge.FieldId _columnsCount10547;
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
			internal static global::MonoJavaBridge.FieldId _rowsCount10548;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/GridLayoutAnimationController$AnimationParameters"));
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._AnimationParameters10544 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _willOverlap10549;
		public override bool willOverlap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._willOverlap10549);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._willOverlap10549);
		}
		internal static global::MonoJavaBridge.MethodId _getDelayForView10550;
		protected override long getDelayForView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getDelayForView10550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDelayForView10550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float ColumnDelay
		{
			get
			{
				return getColumnDelay();
			}
			set
			{
				setColumnDelay(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnDelay10551;
		public virtual float getColumnDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getColumnDelay10551);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getColumnDelay10551);
		}
		internal static global::MonoJavaBridge.MethodId _setColumnDelay10552;
		public virtual void setColumnDelay(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._setColumnDelay10552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setColumnDelay10552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float RowDelay
		{
			get
			{
				return getRowDelay();
			}
			set
			{
				setRowDelay(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRowDelay10553;
		public virtual float getRowDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getRowDelay10553);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getRowDelay10553);
		}
		internal static global::MonoJavaBridge.MethodId _setRowDelay10554;
		public virtual void setRowDelay(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._setRowDelay10554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setRowDelay10554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Direction
		{
			get
			{
				return getDirection();
			}
			set
			{
				setDirection(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDirection10555;
		public virtual int getDirection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getDirection10555);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDirection10555);
		}
		internal static global::MonoJavaBridge.MethodId _setDirection10556;
		public virtual void setDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._setDirection10556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setDirection10556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DirectionPriority
		{
			get
			{
				return getDirectionPriority();
			}
			set
			{
				setDirectionPriority(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDirectionPriority10557;
		public virtual int getDirectionPriority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getDirectionPriority10557);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDirectionPriority10557);
		}
		internal static global::MonoJavaBridge.MethodId _setDirectionPriority10558;
		public virtual void setDirectionPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._setDirectionPriority10558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setDirectionPriority10558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _GridLayoutAnimationController10559;
		public GridLayoutAnimationController(android.view.animation.Animation arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController10559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GridLayoutAnimationController10560;
		public GridLayoutAnimationController(android.view.animation.Animation arg0, float arg1, float arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController10560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GridLayoutAnimationController10561;
		public GridLayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController10561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.GridLayoutAnimationController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/GridLayoutAnimationController"));
			global::android.view.animation.GridLayoutAnimationController._willOverlap10549 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "willOverlap", "()Z");
			global::android.view.animation.GridLayoutAnimationController._getDelayForView10550 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J");
			global::android.view.animation.GridLayoutAnimationController._getColumnDelay10551 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getColumnDelay", "()F");
			global::android.view.animation.GridLayoutAnimationController._setColumnDelay10552 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setColumnDelay", "(F)V");
			global::android.view.animation.GridLayoutAnimationController._getRowDelay10553 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getRowDelay", "()F");
			global::android.view.animation.GridLayoutAnimationController._setRowDelay10554 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setRowDelay", "(F)V");
			global::android.view.animation.GridLayoutAnimationController._getDirection10555 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirection", "()I");
			global::android.view.animation.GridLayoutAnimationController._setDirection10556 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirection", "(I)V");
			global::android.view.animation.GridLayoutAnimationController._getDirectionPriority10557 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirectionPriority", "()I");
			global::android.view.animation.GridLayoutAnimationController._setDirectionPriority10558 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirectionPriority", "(I)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController10559 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController10560 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;FF)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController10561 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
