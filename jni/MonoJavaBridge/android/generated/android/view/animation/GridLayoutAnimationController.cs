namespace android.view.animation
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class GridLayoutAnimationController : android.view.animation.LayoutAnimationController
	{
		internal new static global::java.lang.Class staticClass;
		static GridLayoutAnimationController()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.GridLayoutAnimationController), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.GridLayoutAnimationController.AnimationParameters), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _AnimationParameters9651;
			public AnimationParameters()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, global::android.view.animation.GridLayoutAnimationController.AnimationParameters._AnimationParameters9651, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _column9652;
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
			internal static global::net.sf.jni4net.jni.FieldId _row9653;
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
			internal static global::net.sf.jni4net.jni.FieldId _columnsCount9654;
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
			internal static global::net.sf.jni4net.jni.FieldId _rowsCount9655;
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
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._AnimationParameters9651 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _willOverlap9656;
		public override bool willOverlap() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.GridLayoutAnimationController._willOverlap9656);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._willOverlap9656);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDelayForView9657;
		protected override long getDelayForView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.animation.GridLayoutAnimationController._getDelayForView9657, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDelayForView9657, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnDelay9658;
		public virtual float getColumnDelay() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.animation.GridLayoutAnimationController._getColumnDelay9658);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getColumnDelay9658);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColumnDelay9659;
		public virtual void setColumnDelay(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.GridLayoutAnimationController._setColumnDelay9659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setColumnDelay9659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRowDelay9660;
		public virtual float getRowDelay() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.animation.GridLayoutAnimationController._getRowDelay9660);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getRowDelay9660);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRowDelay9661;
		public virtual void setRowDelay(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.GridLayoutAnimationController._setRowDelay9661, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setRowDelay9661, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDirection9662;
		public virtual int getDirection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.animation.GridLayoutAnimationController._getDirection9662);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDirection9662);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDirection9663;
		public virtual void setDirection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.GridLayoutAnimationController._setDirection9663, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setDirection9663, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDirectionPriority9664;
		public virtual int getDirectionPriority() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.animation.GridLayoutAnimationController._getDirectionPriority9664);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDirectionPriority9664);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDirectionPriority9665;
		public virtual void setDirectionPriority(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.GridLayoutAnimationController._setDirectionPriority9665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setDirectionPriority9665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GridLayoutAnimationController9666;
		public GridLayoutAnimationController(android.view.animation.Animation arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController9666, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GridLayoutAnimationController9667;
		public GridLayoutAnimationController(android.view.animation.Animation arg0, float arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController9667, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GridLayoutAnimationController9668;
		public GridLayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController9668, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
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
			global::android.view.animation.GridLayoutAnimationController._willOverlap9656 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "willOverlap", "()Z");
			global::android.view.animation.GridLayoutAnimationController._getDelayForView9657 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J");
			global::android.view.animation.GridLayoutAnimationController._getColumnDelay9658 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "getColumnDelay", "()F");
			global::android.view.animation.GridLayoutAnimationController._setColumnDelay9659 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "setColumnDelay", "(F)V");
			global::android.view.animation.GridLayoutAnimationController._getRowDelay9660 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "getRowDelay", "()F");
			global::android.view.animation.GridLayoutAnimationController._setRowDelay9661 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "setRowDelay", "(F)V");
			global::android.view.animation.GridLayoutAnimationController._getDirection9662 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirection", "()I");
			global::android.view.animation.GridLayoutAnimationController._setDirection9663 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirection", "(I)V");
			global::android.view.animation.GridLayoutAnimationController._getDirectionPriority9664 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirectionPriority", "()I");
			global::android.view.animation.GridLayoutAnimationController._setDirectionPriority9665 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirectionPriority", "(I)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController9666 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController9667 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;FF)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController9668 = @__env.GetMethodID(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
