namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GridView : android.widget.AbsListView
	{ 
		internal new static global::java.lang.Class staticClass; 
		static GridView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.GridView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.GridView(@__env); 
			} 
		} 
		protected GridView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown9523; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				return @__env.CallBooleanMethod(this, _onKeyDown9523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.GridView.staticClass, _onKeyDown9523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp9524; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				return @__env.CallBooleanMethod(this, _onKeyUp9524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.GridView.staticClass, _onKeyUp9524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple9525; 
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				return @__env.CallBooleanMethod(this, _onKeyMultiple9525, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.GridView.staticClass, _onKeyMultiple9525, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGravity9526; 
		public virtual void setGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _setGravity9526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _setGravity9526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged9527; 
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _onFocusChanged9527, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _onFocusChanged9527, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange9528; 
		protected override int computeVerticalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollRange9528); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.GridView.staticClass, _computeVerticalScrollRange9528); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollOffset9529; 
		protected override int computeVerticalScrollOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollOffset9529); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.GridView.staticClass, _computeVerticalScrollOffset9529); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent9530; 
		protected override int computeVerticalScrollExtent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollExtent9530); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.GridView.staticClass, _computeVerticalScrollExtent9530); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9531; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _onMeasure9531, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _onMeasure9531, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _attachLayoutAnimationParameters9532; 
		protected override void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _attachLayoutAnimationParameters9532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _attachLayoutAnimationParameters9532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9533; 
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _setAdapter9533, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _setAdapter9533, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9534; 
		public override void setAdapter(android.widget.Adapter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _setAdapter9534, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _setAdapter9534, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter9535; 
		public override android.widget.Adapter getAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallObjectMethodPtr(this, _getAdapter9535)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.GridView.staticClass, _getAdapter9535)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9536; 
		public override void setSelection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _setSelection9536, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _setSelection9536, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _layoutChildren9537; 
		protected override void layoutChildren() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _layoutChildren9537); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _layoutChildren9537); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNumColumns9538; 
		public virtual void setNumColumns(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _setNumColumns9538, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _setNumColumns9538, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalSpacing9539; 
		public virtual void setHorizontalSpacing(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _setHorizontalSpacing9539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _setHorizontalSpacing9539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalSpacing9540; 
		public virtual void setVerticalSpacing(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _setVerticalSpacing9540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _setVerticalSpacing9540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStretchMode9541; 
		public virtual void setStretchMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _setStretchMode9541, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _setStretchMode9541, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStretchMode9542; 
		public virtual int getStretchMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				return @__env.CallIntMethod(this, _getStretchMode9542); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.GridView.staticClass, _getStretchMode9542); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColumnWidth9543; 
		public virtual void setColumnWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.GridView)) 
				@__env.CallVoidMethod(this, _setColumnWidth9543, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.GridView.staticClass, _setColumnWidth9543, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GridView9544; 
		public GridView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.GridView.staticClass, _GridView9544, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GridView9545; 
		public GridView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.GridView.staticClass, _GridView9545, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GridView9546; 
		public GridView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.GridView.staticClass, _GridView9546, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int NO_STRETCH
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int STRETCH_SPACING
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int STRETCH_COLUMN_WIDTH
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int STRETCH_SPACING_UNIFORM
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int AUTO_FIT
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.GridView.staticClass = @__class; 
			global::android.widget.GridView._onKeyDown9523 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.GridView._onKeyUp9524 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.GridView._onKeyMultiple9525 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			global::android.widget.GridView._setGravity9526 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setGravity", "(I)V"); 
			global::android.widget.GridView._onFocusChanged9527 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V"); 
			global::android.widget.GridView._computeVerticalScrollRange9528 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "computeVerticalScrollRange", "()I"); 
			global::android.widget.GridView._computeVerticalScrollOffset9529 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "computeVerticalScrollOffset", "()I"); 
			global::android.widget.GridView._computeVerticalScrollExtent9530 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "computeVerticalScrollExtent", "()I"); 
			global::android.widget.GridView._onMeasure9531 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.GridView._attachLayoutAnimationParameters9532 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V"); 
			global::android.widget.GridView._setAdapter9533 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V"); 
			global::android.widget.GridView._setAdapter9534 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V"); 
			global::android.widget.GridView._getAdapter9535 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "getAdapter", "()Landroid/widget/Adapter;"); 
			global::android.widget.GridView._setSelection9536 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setSelection", "(I)V"); 
			global::android.widget.GridView._layoutChildren9537 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "layoutChildren", "()V"); 
			global::android.widget.GridView._setNumColumns9538 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setNumColumns", "(I)V"); 
			global::android.widget.GridView._setHorizontalSpacing9539 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setHorizontalSpacing", "(I)V"); 
			global::android.widget.GridView._setVerticalSpacing9540 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setVerticalSpacing", "(I)V"); 
			global::android.widget.GridView._setStretchMode9541 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setStretchMode", "(I)V"); 
			global::android.widget.GridView._getStretchMode9542 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "getStretchMode", "()I"); 
			global::android.widget.GridView._setColumnWidth9543 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setColumnWidth", "(I)V"); 
			global::android.widget.GridView._GridView9544 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.GridView._GridView9545 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.GridView._GridView9546 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
