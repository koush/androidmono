namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ListView : android.widget.AbsListView
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ListView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ListView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.ListView(@__env); 
			} 
		} 
		protected ListView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class FixedViewInfo : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static FixedViewInfo() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ListView.FixedViewInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.ListView.FixedViewInfo(@__env); 
				} 
			} 
			protected FixedViewInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _FixedViewInfo9681; 
			public FixedViewInfo(android.widget.ListView arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.ListView.FixedViewInfo.staticClass, _FixedViewInfo9681, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _view9682; 
			public android.view.View view
			{ 
				get 
				{ 
					return default(android.view.View); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _data9683; 
			public java.lang.Object data
			{ 
				get 
				{ 
					return default(java.lang.Object); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _isSelectable9684; 
			public bool isSelectable
			{ 
				get 
				{ 
					return default(bool); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.ListView.FixedViewInfo.staticClass = @__class; 
				global::android.widget.ListView.FixedViewInfo._FixedViewInfo9681 = @__env.GetMethodID(global::android.widget.ListView.FixedViewInfo.staticClass, "<init>", "(Landroid/widget/ListView;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState9685; 
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState9685, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _onRestoreInstanceState9685, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState9686; 
		public override android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState9686)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ListView.staticClass, _onSaveInstanceState9686)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown9687; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _onKeyDown9687, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _onKeyDown9687, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp9688; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _onKeyUp9688, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _onKeyUp9688, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple9689; 
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _onKeyMultiple9689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _onKeyMultiple9689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent9690; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent9690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _onTouchEvent9690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent9691; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEvent9691, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _dispatchKeyEvent9691, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent9692; 
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _dispatchPopulateAccessibilityEvent9692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _dispatchPopulateAccessibilityEvent9692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged9693; 
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _onFocusChanged9693, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _onFocusChanged9693, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw9694; 
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _dispatchDraw9694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _dispatchDraw9694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate9695; 
		protected override void onFinishInflate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _onFinishInflate9695); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _onFinishInflate9695); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9696; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _onMeasure9696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _onMeasure9696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen9697; 
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _requestChildRectangleOnScreen9697, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _requestChildRectangleOnScreen9697, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canAnimate9698; 
		protected override bool canAnimate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _canAnimate9698); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _canAnimate9698); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9699; 
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setAdapter9699, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setAdapter9699, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9700; 
		public override void setAdapter(android.widget.Adapter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setAdapter9700, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setAdapter9700, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performItemClick9701; 
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _performItemClick9701, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _performItemClick9701, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter9702; 
		public override android.widget.Adapter getAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallObjectMethodPtr(this, _getAdapter9702)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ListView.staticClass, _getAdapter9702)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9703; 
		public override void setSelection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setSelection9703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setSelection9703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxScrollAmount9704; 
		public virtual int getMaxScrollAmount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallIntMethod(this, _getMaxScrollAmount9704); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ListView.staticClass, _getMaxScrollAmount9704); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addHeaderView9705; 
		public virtual void addHeaderView(android.view.View arg0, java.lang.Object arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _addHeaderView9705, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _addHeaderView9705, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addHeaderView9706; 
		public virtual void addHeaderView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _addHeaderView9706, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _addHeaderView9706, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderViewsCount9707; 
		public virtual int getHeaderViewsCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallIntMethod(this, _getHeaderViewsCount9707); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ListView.staticClass, _getHeaderViewsCount9707); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeHeaderView9708; 
		public virtual bool removeHeaderView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _removeHeaderView9708, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _removeHeaderView9708, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFooterView9709; 
		public virtual void addFooterView(android.view.View arg0, java.lang.Object arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _addFooterView9709, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _addFooterView9709, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFooterView9710; 
		public virtual void addFooterView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _addFooterView9710, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _addFooterView9710, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFooterViewsCount9711; 
		public virtual int getFooterViewsCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallIntMethod(this, _getFooterViewsCount9711); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ListView.staticClass, _getFooterViewsCount9711); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeFooterView9712; 
		public virtual bool removeFooterView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _removeFooterView9712, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _removeFooterView9712, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _layoutChildren9713; 
		protected override void layoutChildren() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _layoutChildren9713); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _layoutChildren9713); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelectionFromTop9714; 
		public virtual void setSelectionFromTop(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setSelectionFromTop9714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setSelectionFromTop9714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelectionAfterHeaderView9715; 
		public virtual void setSelectionAfterHeaderView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setSelectionAfterHeaderView9715); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setSelectionAfterHeaderView9715); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setItemsCanFocus9716; 
		public virtual void setItemsCanFocus(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setItemsCanFocus9716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setItemsCanFocus9716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemsCanFocus9717; 
		public virtual bool getItemsCanFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _getItemsCanFocus9717); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _getItemsCanFocus9717); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCacheColorHint9718; 
		public override void setCacheColorHint(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setCacheColorHint9718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setCacheColorHint9718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDivider9719; 
		public virtual android.graphics.drawable.Drawable getDivider() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDivider9719)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ListView.staticClass, _getDivider9719)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDivider9720; 
		public virtual void setDivider(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setDivider9720, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setDivider9720, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDividerHeight9721; 
		public virtual int getDividerHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallIntMethod(this, _getDividerHeight9721); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ListView.staticClass, _getDividerHeight9721); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDividerHeight9722; 
		public virtual void setDividerHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setDividerHeight9722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setDividerHeight9722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderDividersEnabled9723; 
		public virtual void setHeaderDividersEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setHeaderDividersEnabled9723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setHeaderDividersEnabled9723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFooterDividersEnabled9724; 
		public virtual void setFooterDividersEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setFooterDividersEnabled9724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setFooterDividersEnabled9724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findViewTraversal9725; 
		protected virtual android.view.View findViewTraversal(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _findViewTraversal9725, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ListView.staticClass, _findViewTraversal9725, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findViewWithTagTraversal9726; 
		protected virtual android.view.View findViewWithTagTraversal(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _findViewWithTagTraversal9726, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ListView.staticClass, _findViewWithTagTraversal9726, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChoiceMode9727; 
		public virtual int getChoiceMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallIntMethod(this, _getChoiceMode9727); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ListView.staticClass, _getChoiceMode9727); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChoiceMode9728; 
		public virtual void setChoiceMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setChoiceMode9728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setChoiceMode9728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setItemChecked9729; 
		public virtual void setItemChecked(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _setItemChecked9729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _setItemChecked9729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isItemChecked9730; 
		public virtual bool isItemChecked(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallBooleanMethod(this, _isItemChecked9730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ListView.staticClass, _isItemChecked9730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCheckedItemPosition9731; 
		public virtual int getCheckedItemPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return @__env.CallIntMethod(this, _getCheckedItemPosition9731); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ListView.staticClass, _getCheckedItemPosition9731); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCheckedItemPositions9732; 
		public virtual android.util.SparseBooleanArray getCheckedItemPositions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseBooleanArray>(@__env, @__env.CallObjectMethodPtr(this, _getCheckedItemPositions9732)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseBooleanArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ListView.staticClass, _getCheckedItemPositions9732)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCheckItemIds9733; 
		public virtual long[] getCheckItemIds() 
		{ 
			if (GetType() == typeof(android.widget.ListView)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getCheckItemIds9733)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ListView.staticClass, _getCheckItemIds9733)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearChoices9734; 
		public virtual void clearChoices() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ListView)) 
				@__env.CallVoidMethod(this, _clearChoices9734); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ListView.staticClass, _clearChoices9734); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ListView9735; 
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ListView.staticClass, _ListView9735, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ListView9736; 
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ListView.staticClass, _ListView9736, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ListView9737; 
		public ListView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ListView.staticClass, _ListView9737, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int CHOICE_MODE_NONE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int CHOICE_MODE_SINGLE
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int CHOICE_MODE_MULTIPLE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ListView.staticClass = @__class; 
			global::android.widget.ListView._onRestoreInstanceState9685 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.widget.ListView._onSaveInstanceState9686 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.widget.ListView._onKeyDown9687 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.ListView._onKeyUp9688 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.ListView._onKeyMultiple9689 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			global::android.widget.ListView._onTouchEvent9690 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.ListView._dispatchKeyEvent9691 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.widget.ListView._dispatchPopulateAccessibilityEvent9692 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.widget.ListView._onFocusChanged9693 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V"); 
			global::android.widget.ListView._dispatchDraw9694 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.ListView._onFinishInflate9695 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onFinishInflate", "()V"); 
			global::android.widget.ListView._onMeasure9696 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.ListView._requestChildRectangleOnScreen9697 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z"); 
			global::android.widget.ListView._canAnimate9698 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "canAnimate", "()Z"); 
			global::android.widget.ListView._setAdapter9699 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V"); 
			global::android.widget.ListView._setAdapter9700 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V"); 
			global::android.widget.ListView._performItemClick9701 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z"); 
			global::android.widget.ListView._getAdapter9702 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getAdapter", "()Landroid/widget/Adapter;"); 
			global::android.widget.ListView._setSelection9703 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setSelection", "(I)V"); 
			global::android.widget.ListView._getMaxScrollAmount9704 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getMaxScrollAmount", "()I"); 
			global::android.widget.ListView._addHeaderView9705 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;Ljava/lang/Object;Z)V"); 
			global::android.widget.ListView._addHeaderView9706 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;)V"); 
			global::android.widget.ListView._getHeaderViewsCount9707 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getHeaderViewsCount", "()I"); 
			global::android.widget.ListView._removeHeaderView9708 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "removeHeaderView", "(Landroid/view/View;)Z"); 
			global::android.widget.ListView._addFooterView9709 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;Ljava/lang/Object;Z)V"); 
			global::android.widget.ListView._addFooterView9710 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;)V"); 
			global::android.widget.ListView._getFooterViewsCount9711 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getFooterViewsCount", "()I"); 
			global::android.widget.ListView._removeFooterView9712 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "removeFooterView", "(Landroid/view/View;)Z"); 
			global::android.widget.ListView._layoutChildren9713 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "layoutChildren", "()V"); 
			global::android.widget.ListView._setSelectionFromTop9714 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setSelectionFromTop", "(II)V"); 
			global::android.widget.ListView._setSelectionAfterHeaderView9715 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setSelectionAfterHeaderView", "()V"); 
			global::android.widget.ListView._setItemsCanFocus9716 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setItemsCanFocus", "(Z)V"); 
			global::android.widget.ListView._getItemsCanFocus9717 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getItemsCanFocus", "()Z"); 
			global::android.widget.ListView._setCacheColorHint9718 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setCacheColorHint", "(I)V"); 
			global::android.widget.ListView._getDivider9719 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getDivider", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.ListView._setDivider9720 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setDivider", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ListView._getDividerHeight9721 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getDividerHeight", "()I"); 
			global::android.widget.ListView._setDividerHeight9722 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setDividerHeight", "(I)V"); 
			global::android.widget.ListView._setHeaderDividersEnabled9723 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setHeaderDividersEnabled", "(Z)V"); 
			global::android.widget.ListView._setFooterDividersEnabled9724 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setFooterDividersEnabled", "(Z)V"); 
			global::android.widget.ListView._findViewTraversal9725 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "findViewTraversal", "(I)Landroid/view/View;"); 
			global::android.widget.ListView._findViewWithTagTraversal9726 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "findViewWithTagTraversal", "(Ljava/lang/Object;)Landroid/view/View;"); 
			global::android.widget.ListView._getChoiceMode9727 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getChoiceMode", "()I"); 
			global::android.widget.ListView._setChoiceMode9728 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setChoiceMode", "(I)V"); 
			global::android.widget.ListView._setItemChecked9729 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setItemChecked", "(IZ)V"); 
			global::android.widget.ListView._isItemChecked9730 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "isItemChecked", "(I)Z"); 
			global::android.widget.ListView._getCheckedItemPosition9731 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getCheckedItemPosition", "()I"); 
			global::android.widget.ListView._getCheckedItemPositions9732 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getCheckedItemPositions", "()Landroid/util/SparseBooleanArray;"); 
			global::android.widget.ListView._getCheckItemIds9733 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getCheckItemIds", "()[J"); 
			global::android.widget.ListView._clearChoices9734 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "clearChoices", "()V"); 
			global::android.widget.ListView._ListView9735 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.ListView._ListView9736 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.ListView._ListView9737 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
