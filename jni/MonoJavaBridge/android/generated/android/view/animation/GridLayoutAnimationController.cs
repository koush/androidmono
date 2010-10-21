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
			internal static global::MonoJavaBridge.MethodId _AnimationParameters15603;
			public AnimationParameters()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, global::android.view.animation.GridLayoutAnimationController.AnimationParameters._AnimationParameters15603);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _column15604;
			public int column
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _column15604);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _row15605;
			public int row
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _row15605);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _columnsCount15606;
			public int columnsCount
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _columnsCount15606);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _rowsCount15607;
			public int rowsCount
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _rowsCount15607);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/GridLayoutAnimationController$AnimationParameters"));
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._AnimationParameters15603 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V");
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._column15604 = @__env.GetFieldIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "column", "I");
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._row15605 = @__env.GetFieldIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "row", "I");
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._columnsCount15606 = @__env.GetFieldIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "columnsCount", "I");
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._rowsCount15607 = @__env.GetFieldIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "rowsCount", "I");
			}
		}
		internal static global::MonoJavaBridge.MethodId _willOverlap15608;
		public override bool willOverlap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._willOverlap15608);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._willOverlap15608);
		}
		internal static global::MonoJavaBridge.MethodId _getDelayForView15609;
		protected override long getDelayForView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getDelayForView15609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDelayForView15609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getColumnDelay15610;
		public virtual float getColumnDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getColumnDelay15610);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getColumnDelay15610);
		}
		internal static global::MonoJavaBridge.MethodId _setColumnDelay15611;
		public virtual void setColumnDelay(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._setColumnDelay15611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setColumnDelay15611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getRowDelay15612;
		public virtual float getRowDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getRowDelay15612);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getRowDelay15612);
		}
		internal static global::MonoJavaBridge.MethodId _setRowDelay15613;
		public virtual void setRowDelay(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._setRowDelay15613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setRowDelay15613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDirection15614;
		public virtual int getDirection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getDirection15614);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDirection15614);
		}
		internal static global::MonoJavaBridge.MethodId _setDirection15615;
		public virtual void setDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._setDirection15615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setDirection15615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDirectionPriority15616;
		public virtual int getDirectionPriority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getDirectionPriority15616);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDirectionPriority15616);
		}
		internal static global::MonoJavaBridge.MethodId _setDirectionPriority15617;
		public virtual void setDirectionPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._setDirectionPriority15617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setDirectionPriority15617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _GridLayoutAnimationController15618;
		public GridLayoutAnimationController(android.view.animation.Animation arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController15618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GridLayoutAnimationController15619;
		public GridLayoutAnimationController(android.view.animation.Animation arg0, float arg1, float arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController15619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GridLayoutAnimationController15620;
		public GridLayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController15620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::android.view.animation.GridLayoutAnimationController._willOverlap15608 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "willOverlap", "()Z");
			global::android.view.animation.GridLayoutAnimationController._getDelayForView15609 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J");
			global::android.view.animation.GridLayoutAnimationController._getColumnDelay15610 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getColumnDelay", "()F");
			global::android.view.animation.GridLayoutAnimationController._setColumnDelay15611 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setColumnDelay", "(F)V");
			global::android.view.animation.GridLayoutAnimationController._getRowDelay15612 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getRowDelay", "()F");
			global::android.view.animation.GridLayoutAnimationController._setRowDelay15613 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setRowDelay", "(F)V");
			global::android.view.animation.GridLayoutAnimationController._getDirection15614 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirection", "()I");
			global::android.view.animation.GridLayoutAnimationController._setDirection15615 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirection", "(I)V");
			global::android.view.animation.GridLayoutAnimationController._getDirectionPriority15616 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirectionPriority", "()I");
			global::android.view.animation.GridLayoutAnimationController._setDirectionPriority15617 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirectionPriority", "(I)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController15618 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController15619 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;FF)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController15620 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
