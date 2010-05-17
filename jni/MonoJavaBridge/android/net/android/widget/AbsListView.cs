namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbsListView : android.widget.AdapterView, android.text.TextWatcher, android.view.ViewTreeObserver.OnGlobalLayoutListener, android.widget.Filter.FilterListener, android.view.ViewTreeObserver.OnTouchModeChangeListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbsListView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.AbsListView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbsListView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public new class LayoutParams : android.view.ViewGroup.LayoutParams
		{ 
			internal new static global::java.lang.Class staticClass; 
			static LayoutParams() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.AbsListView.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.AbsListView.LayoutParams(@__env); 
				} 
			} 
			protected LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams8961; 
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, _LayoutParams8961, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams8962; 
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, _LayoutParams8962, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams8963; 
			public LayoutParams(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, _LayoutParams8963, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams8964; 
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, _LayoutParams8964, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.AbsListView.LayoutParams.staticClass = @__class; 
				global::android.widget.AbsListView.LayoutParams._LayoutParams8961 = @__env.GetMethodID(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.widget.AbsListView.LayoutParams._LayoutParams8962 = @__env.GetMethodID(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.widget.AbsListView.LayoutParams._LayoutParams8963 = @__env.GetMethodID(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(III)V"); 
				global::android.widget.AbsListView.LayoutParams._LayoutParams8964 = @__env.GetMethodID(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnScrollListener 
		{ 
			void onScroll(android.widget.AbsListView arg0, int arg1, int arg2, int arg3); 
			void onScrollStateChanged(android.widget.AbsListView arg0, int arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class OnScrollListenerConstants 
		{ 
			public static int SCROLL_STATE_IDLE
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int SCROLL_STATE_TOUCH_SCROLL
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int SCROLL_STATE_FLING
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface RecyclerListener 
		{ 
			void onMovedToScrapHeap(android.view.View arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw8965; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _draw8965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _draw8965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState8966; 
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState8966, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _onRestoreInstanceState8966, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState8967; 
		public virtual new android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState8967)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsListView.staticClass, _onSaveInstanceState8967)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown8968; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _onKeyDown8968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _onKeyDown8968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp8969; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _onKeyUp8969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _onKeyUp8969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent8970; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent8970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _onTouchEvent8970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged8971; 
		public override void onWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _onWindowFocusChanged8971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _onWindowFocusChanged8971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow8972; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _onAttachedToWindow8972); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _onAttachedToWindow8972); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow8973; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow8973); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _onDetachedFromWindow8973); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged8974; 
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _onFocusChanged8974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _onFocusChanged8974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetPressed8975; 
		protected override void dispatchSetPressed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _dispatchSetPressed8975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _dispatchSetPressed8975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addTouchables8976; 
		public override void addTouchables(java.util.ArrayList arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _addTouchables8976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _addTouchables8976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputConnection8977; 
		public override android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, _onCreateInputConnection8977, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsListView.staticClass, _onCreateInputConnection8977, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkInputConnectionProxy8978; 
		public override bool checkInputConnectionProxy(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _checkInputConnectionProxy8978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _checkInputConnectionProxy8978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContextMenuInfo8979; 
		protected override android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallObjectMethodPtr(this, _getContextMenuInfo8979)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsListView.staticClass, _getContextMenuInfo8979)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged8980; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _onSizeChanged8980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _onSizeChanged8980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw8981; 
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _dispatchDraw8981, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _dispatchDraw8981, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFocusedRect8982; 
		public override void getFocusedRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _getFocusedRect8982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _getFocusedRect8982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTopFadingEdgeStrength8983; 
		protected override float getTopFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallFloatMethod(this, _getTopFadingEdgeStrength8983); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.AbsListView.staticClass, _getTopFadingEdgeStrength8983); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottomFadingEdgeStrength8984; 
		protected override float getBottomFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallFloatMethod(this, _getBottomFadingEdgeStrength8984); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.AbsListView.staticClass, _getBottomFadingEdgeStrength8984); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange8985; 
		protected override int computeVerticalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollRange8985); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsListView.staticClass, _computeVerticalScrollRange8985); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollOffset8986; 
		protected override int computeVerticalScrollOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollOffset8986); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsListView.staticClass, _computeVerticalScrollOffset8986); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent8987; 
		protected override int computeVerticalScrollExtent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollExtent8987); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsListView.staticClass, _computeVerticalScrollExtent8987); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSolidColor8988; 
		public override int getSolidColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallIntMethod(this, _getSolidColor8988); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsListView.staticClass, _getSolidColor8988); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout8989; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _onLayout8989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _onLayout8989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable8990; 
		public virtual new bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _verifyDrawable8990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _verifyDrawable8990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged8991; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _drawableStateChanged8991); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _drawableStateChanged8991); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState8992; 
		protected override int[] onCreateDrawableState(int arg0) 
		{ 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _onCreateDrawableState8992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsListView.staticClass, _onCreateDrawableState8992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout8993; 
		public override void requestLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _requestLayout8993); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _requestLayout8993); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure8994; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _onMeasure8994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _onMeasure8994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenuForChild8995; 
		public override bool showContextMenuForChild(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _showContextMenuForChild8995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _showContextMenuForChild8995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent8996; 
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _onInterceptTouchEvent8996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _onInterceptTouchEvent8996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams8997; 
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _checkLayoutParams8997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _checkLayoutParams8997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams8998; 
		public virtual new android.widget.AbsListView.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.AbsListView.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams8998, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.AbsListView.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsListView.staticClass, _generateLayoutParams8998, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams8999; 
		protected override android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams8999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsListView.staticClass, _generateLayoutParams8999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedView9000; 
		public override android.view.View getSelectedView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getSelectedView9000)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsListView.staticClass, _getSelectedView9000)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTextChanged9001; 
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _onTextChanged9001, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _onTextChanged9001, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _layoutChildren9002; 
		protected virtual void layoutChildren() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _layoutChildren9002); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _layoutChildren9002); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCacheColorHint9003; 
		public virtual void setCacheColorHint(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setCacheColorHint9003, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setCacheColorHint9003, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFastScrollEnabled9004; 
		public virtual void setFastScrollEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setFastScrollEnabled9004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setFastScrollEnabled9004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFastScrollEnabled9005; 
		public virtual bool isFastScrollEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _isFastScrollEnabled9005); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _isFastScrollEnabled9005); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSmoothScrollbarEnabled9006; 
		public virtual void setSmoothScrollbarEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setSmoothScrollbarEnabled9006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setSmoothScrollbarEnabled9006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSmoothScrollbarEnabled9007; 
		public virtual bool isSmoothScrollbarEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _isSmoothScrollbarEnabled9007); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _isSmoothScrollbarEnabled9007); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnScrollListener9008; 
		public virtual void setOnScrollListener(android.widget.AbsListView.OnScrollListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setOnScrollListener9008, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setOnScrollListener9008, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isScrollingCacheEnabled9009; 
		public virtual bool isScrollingCacheEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _isScrollingCacheEnabled9009); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _isScrollingCacheEnabled9009); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScrollingCacheEnabled9010; 
		public virtual void setScrollingCacheEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setScrollingCacheEnabled9010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setScrollingCacheEnabled9010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextFilterEnabled9011; 
		public virtual void setTextFilterEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setTextFilterEnabled9011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setTextFilterEnabled9011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isTextFilterEnabled9012; 
		public virtual bool isTextFilterEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _isTextFilterEnabled9012); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _isTextFilterEnabled9012); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStackFromBottom9013; 
		public virtual bool isStackFromBottom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _isStackFromBottom9013); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _isStackFromBottom9013); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStackFromBottom9014; 
		public virtual void setStackFromBottom(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setStackFromBottom9014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setStackFromBottom9014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterText9015; 
		public virtual void setFilterText(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setFilterText9015, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setFilterText9015, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextFilter9016; 
		public virtual java.lang.CharSequence getTextFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTextFilter9016)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsListView.staticClass, _getTextFilter9016)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getListPaddingTop9017; 
		public virtual int getListPaddingTop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallIntMethod(this, _getListPaddingTop9017); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsListView.staticClass, _getListPaddingTop9017); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getListPaddingBottom9018; 
		public virtual int getListPaddingBottom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallIntMethod(this, _getListPaddingBottom9018); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsListView.staticClass, _getListPaddingBottom9018); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getListPaddingLeft9019; 
		public virtual int getListPaddingLeft() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallIntMethod(this, _getListPaddingLeft9019); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsListView.staticClass, _getListPaddingLeft9019); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getListPaddingRight9020; 
		public virtual int getListPaddingRight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallIntMethod(this, _getListPaddingRight9020); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsListView.staticClass, _getListPaddingRight9020); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDrawSelectorOnTop9021; 
		public virtual void setDrawSelectorOnTop(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setDrawSelectorOnTop9021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setDrawSelectorOnTop9021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelector9022; 
		public virtual void setSelector(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setSelector9022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setSelector9022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelector9023; 
		public virtual void setSelector(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setSelector9023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setSelector9023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelector9024; 
		public virtual android.graphics.drawable.Drawable getSelector() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getSelector9024)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AbsListView.staticClass, _getSelector9024)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScrollIndicators9025; 
		public virtual void setScrollIndicators(android.view.View arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setScrollIndicators9025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setScrollIndicators9025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pointToPosition9026; 
		public virtual int pointToPosition(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallIntMethod(this, _pointToPosition9026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsListView.staticClass, _pointToPosition9026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pointToRowId9027; 
		public virtual long pointToRowId(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallLongMethod(this, _pointToRowId9027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.AbsListView.staticClass, _pointToRowId9027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchModeChanged9028; 
		public virtual void onTouchModeChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _onTouchModeChanged9028, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _onTouchModeChanged9028, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateViews9029; 
		public virtual void invalidateViews() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _invalidateViews9029); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _invalidateViews9029); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _handleDataChanged9030; 
		protected virtual void handleDataChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _handleDataChanged9030); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _handleDataChanged9030); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInFilterMode9031; 
		protected virtual bool isInFilterMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _isInFilterMode9031); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _isInFilterMode9031); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearTextFilter9032; 
		public virtual void clearTextFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _clearTextFilter9032); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _clearTextFilter9032); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasTextFilter9033; 
		public virtual bool hasTextFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallBooleanMethod(this, _hasTextFilter9033); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AbsListView.staticClass, _hasTextFilter9033); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGlobalLayout9034; 
		public virtual void onGlobalLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _onGlobalLayout9034); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _onGlobalLayout9034); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beforeTextChanged9035; 
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _beforeTextChanged9035, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _beforeTextChanged9035, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _afterTextChanged9036; 
		public virtual void afterTextChanged(android.text.Editable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _afterTextChanged9036, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _afterTextChanged9036, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFilterComplete9037; 
		public virtual void onFilterComplete(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _onFilterComplete9037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _onFilterComplete9037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTranscriptMode9038; 
		public virtual void setTranscriptMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setTranscriptMode9038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setTranscriptMode9038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTranscriptMode9039; 
		public virtual int getTranscriptMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallIntMethod(this, _getTranscriptMode9039); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsListView.staticClass, _getTranscriptMode9039); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCacheColorHint9040; 
		public virtual int getCacheColorHint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				return @__env.CallIntMethod(this, _getCacheColorHint9040); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AbsListView.staticClass, _getCacheColorHint9040); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reclaimViews9041; 
		public virtual void reclaimViews(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _reclaimViews9041, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _reclaimViews9041, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRecyclerListener9042; 
		public virtual void setRecyclerListener(android.widget.AbsListView.RecyclerListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AbsListView)) 
				@__env.CallVoidMethod(this, _setRecyclerListener9042, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AbsListView.staticClass, _setRecyclerListener9042, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsListView9043; 
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AbsListView.staticClass, _AbsListView9043, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsListView9044; 
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AbsListView.staticClass, _AbsListView9044, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsListView9045; 
		public AbsListView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AbsListView.staticClass, _AbsListView9045, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int TRANSCRIPT_MODE_DISABLED
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int TRANSCRIPT_MODE_NORMAL
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int TRANSCRIPT_MODE_ALWAYS_SCROLL
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.AbsListView.staticClass = @__class; 
			global::android.widget.AbsListView._draw8965 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.AbsListView._onRestoreInstanceState8966 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.widget.AbsListView._onSaveInstanceState8967 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.widget.AbsListView._onKeyDown8968 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.AbsListView._onKeyUp8969 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.AbsListView._onTouchEvent8970 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.AbsListView._onWindowFocusChanged8971 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onWindowFocusChanged", "(Z)V"); 
			global::android.widget.AbsListView._onAttachedToWindow8972 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onAttachedToWindow", "()V"); 
			global::android.widget.AbsListView._onDetachedFromWindow8973 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.widget.AbsListView._onFocusChanged8974 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V"); 
			global::android.widget.AbsListView._dispatchSetPressed8975 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "dispatchSetPressed", "(Z)V"); 
			global::android.widget.AbsListView._addTouchables8976 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V"); 
			global::android.widget.AbsListView._onCreateInputConnection8977 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;"); 
			global::android.widget.AbsListView._checkInputConnectionProxy8978 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z"); 
			global::android.widget.AbsListView._getContextMenuInfo8979 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;"); 
			global::android.widget.AbsListView._onSizeChanged8980 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.widget.AbsListView._dispatchDraw8981 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.AbsListView._getFocusedRect8982 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V"); 
			global::android.widget.AbsListView._getTopFadingEdgeStrength8983 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getTopFadingEdgeStrength", "()F"); 
			global::android.widget.AbsListView._getBottomFadingEdgeStrength8984 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getBottomFadingEdgeStrength", "()F"); 
			global::android.widget.AbsListView._computeVerticalScrollRange8985 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "computeVerticalScrollRange", "()I"); 
			global::android.widget.AbsListView._computeVerticalScrollOffset8986 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "computeVerticalScrollOffset", "()I"); 
			global::android.widget.AbsListView._computeVerticalScrollExtent8987 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "computeVerticalScrollExtent", "()I"); 
			global::android.widget.AbsListView._getSolidColor8988 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getSolidColor", "()I"); 
			global::android.widget.AbsListView._onLayout8989 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.AbsListView._verifyDrawable8990 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z"); 
			global::android.widget.AbsListView._drawableStateChanged8991 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "drawableStateChanged", "()V"); 
			global::android.widget.AbsListView._onCreateDrawableState8992 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onCreateDrawableState", "(I)[I"); 
			global::android.widget.AbsListView._requestLayout8993 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "requestLayout", "()V"); 
			global::android.widget.AbsListView._onMeasure8994 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.AbsListView._showContextMenuForChild8995 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z"); 
			global::android.widget.AbsListView._onInterceptTouchEvent8996 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.AbsListView._checkLayoutParams8997 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.widget.AbsListView._generateLayoutParams8998 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/AbsListView$LayoutParams;"); 
			global::android.widget.AbsListView._generateLayoutParams8999 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.widget.AbsListView._getSelectedView9000 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getSelectedView", "()Landroid/view/View;"); 
			global::android.widget.AbsListView._onTextChanged9001 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V"); 
			global::android.widget.AbsListView._layoutChildren9002 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "layoutChildren", "()V"); 
			global::android.widget.AbsListView._setCacheColorHint9003 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setCacheColorHint", "(I)V"); 
			global::android.widget.AbsListView._setFastScrollEnabled9004 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setFastScrollEnabled", "(Z)V"); 
			global::android.widget.AbsListView._isFastScrollEnabled9005 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isFastScrollEnabled", "()Z"); 
			global::android.widget.AbsListView._setSmoothScrollbarEnabled9006 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setSmoothScrollbarEnabled", "(Z)V"); 
			global::android.widget.AbsListView._isSmoothScrollbarEnabled9007 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isSmoothScrollbarEnabled", "()Z"); 
			global::android.widget.AbsListView._setOnScrollListener9008 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V"); 
			global::android.widget.AbsListView._isScrollingCacheEnabled9009 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isScrollingCacheEnabled", "()Z"); 
			global::android.widget.AbsListView._setScrollingCacheEnabled9010 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setScrollingCacheEnabled", "(Z)V"); 
			global::android.widget.AbsListView._setTextFilterEnabled9011 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setTextFilterEnabled", "(Z)V"); 
			global::android.widget.AbsListView._isTextFilterEnabled9012 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isTextFilterEnabled", "()Z"); 
			global::android.widget.AbsListView._isStackFromBottom9013 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isStackFromBottom", "()Z"); 
			global::android.widget.AbsListView._setStackFromBottom9014 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setStackFromBottom", "(Z)V"); 
			global::android.widget.AbsListView._setFilterText9015 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setFilterText", "(Ljava/lang/String;)V"); 
			global::android.widget.AbsListView._getTextFilter9016 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getTextFilter", "()Ljava/lang/CharSequence;"); 
			global::android.widget.AbsListView._getListPaddingTop9017 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getListPaddingTop", "()I"); 
			global::android.widget.AbsListView._getListPaddingBottom9018 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getListPaddingBottom", "()I"); 
			global::android.widget.AbsListView._getListPaddingLeft9019 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getListPaddingLeft", "()I"); 
			global::android.widget.AbsListView._getListPaddingRight9020 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getListPaddingRight", "()I"); 
			global::android.widget.AbsListView._setDrawSelectorOnTop9021 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setDrawSelectorOnTop", "(Z)V"); 
			global::android.widget.AbsListView._setSelector9022 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setSelector", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.AbsListView._setSelector9023 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setSelector", "(I)V"); 
			global::android.widget.AbsListView._getSelector9024 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getSelector", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.AbsListView._setScrollIndicators9025 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setScrollIndicators", "(Landroid/view/View;Landroid/view/View;)V"); 
			global::android.widget.AbsListView._pointToPosition9026 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "pointToPosition", "(II)I"); 
			global::android.widget.AbsListView._pointToRowId9027 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "pointToRowId", "(II)J"); 
			global::android.widget.AbsListView._onTouchModeChanged9028 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onTouchModeChanged", "(Z)V"); 
			global::android.widget.AbsListView._invalidateViews9029 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "invalidateViews", "()V"); 
			global::android.widget.AbsListView._handleDataChanged9030 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "handleDataChanged", "()V"); 
			global::android.widget.AbsListView._isInFilterMode9031 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isInFilterMode", "()Z"); 
			global::android.widget.AbsListView._clearTextFilter9032 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "clearTextFilter", "()V"); 
			global::android.widget.AbsListView._hasTextFilter9033 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "hasTextFilter", "()Z"); 
			global::android.widget.AbsListView._onGlobalLayout9034 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onGlobalLayout", "()V"); 
			global::android.widget.AbsListView._beforeTextChanged9035 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V"); 
			global::android.widget.AbsListView._afterTextChanged9036 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V"); 
			global::android.widget.AbsListView._onFilterComplete9037 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onFilterComplete", "(I)V"); 
			global::android.widget.AbsListView._setTranscriptMode9038 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setTranscriptMode", "(I)V"); 
			global::android.widget.AbsListView._getTranscriptMode9039 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getTranscriptMode", "()I"); 
			global::android.widget.AbsListView._getCacheColorHint9040 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getCacheColorHint", "()I"); 
			global::android.widget.AbsListView._reclaimViews9041 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "reclaimViews", "(Ljava/util/List;)V"); 
			global::android.widget.AbsListView._setRecyclerListener9042 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setRecyclerListener", "(Landroid/widget/AbsListView$RecyclerListener;)V"); 
			global::android.widget.AbsListView._AbsListView9043 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.AbsListView._AbsListView9044 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.AbsListView._AbsListView9045 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
