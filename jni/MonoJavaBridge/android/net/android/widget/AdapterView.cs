namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AdapterView : android.view.ViewGroup
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AdapterView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.AdapterView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AdapterView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class AdapterContextMenuInfo : java.lang.Object, android.view.ContextMenu_ContextMenuInfo
		{ 
			internal static global::java.lang.Class staticClass; 
			static AdapterContextMenuInfo() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.AdapterView.AdapterContextMenuInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.AdapterView.AdapterContextMenuInfo(@__env); 
				} 
			} 
			protected AdapterContextMenuInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _AdapterContextMenuInfo9093; 
			public AdapterContextMenuInfo(android.view.View arg0, int arg1, long arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.AdapterView.AdapterContextMenuInfo.staticClass, _AdapterContextMenuInfo9093, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _targetView9094; 
			public android.view.View targetView
			{ 
				get 
				{ 
					return default(android.view.View); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _position9095; 
			public int position
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _id9096; 
			public long id
			{ 
				get 
				{ 
					return default(long); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass = @__class; 
				global::android.widget.AdapterView.AdapterContextMenuInfo._AdapterContextMenuInfo9093 = @__env.GetMethodID(global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;IJ)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnItemClickListener 
		{ 
			void onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnItemLongClickListener 
		{ 
			bool onItemLongClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnItemSelectedListener 
		{ 
			void onItemSelected(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3); 
			void onNothingSelected(android.widget.AdapterView arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent9097; 
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallBooleanMethod(this, _dispatchPopulateAccessibilityEvent9097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AdapterView.staticClass, _dispatchPopulateAccessibilityEvent9097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9098; 
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _addView9098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _addView9098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9099; 
		public override void addView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _addView9099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _addView9099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9100; 
		public override void addView(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _addView9100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _addView9100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9101; 
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _addView9101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _addView9101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeView9102; 
		public override void removeView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _removeView9102, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _removeView9102, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnClickListener9103; 
		public override void setOnClickListener(android.view.View.OnClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setOnClickListener9103, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setOnClickListener9103, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFocusable9104; 
		public override void setFocusable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setFocusable9104, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setFocusable9104, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFocusableInTouchMode9105; 
		public override void setFocusableInTouchMode(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setFocusableInTouchMode9105, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setFocusableInTouchMode9105, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState9106; 
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _dispatchSaveInstanceState9106, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _dispatchSaveInstanceState9106, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState9107; 
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _dispatchRestoreInstanceState9107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _dispatchRestoreInstanceState9107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout9108; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _onLayout9108, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _onLayout9108, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount9109; 
		public virtual int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallIntMethod(this, _getCount9109); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AdapterView.staticClass, _getCount9109); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewAt9110; 
		public override void removeViewAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _removeViewAt9110, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _removeViewAt9110, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViews9111; 
		public override void removeAllViews() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _removeAllViews9111); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _removeAllViews9111); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canAnimate9112; 
		protected override bool canAnimate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallBooleanMethod(this, _canAnimate9112); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AdapterView.staticClass, _canAnimate9112); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9113; 
		public abstract void setAdapter(android.widget.Adapter arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemSelectedListener9114; 
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setOnItemSelectedListener9114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setOnItemSelectedListener9114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemClickListener9115; 
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setOnItemClickListener9115, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setOnItemClickListener9115, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemClickListener9116; 
		public virtual android.widget.AdapterView.OnItemClickListener getOnItemClickListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnItemClickListener9116)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AdapterView.staticClass, _getOnItemClickListener9116)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performItemClick9117; 
		public virtual bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallBooleanMethod(this, _performItemClick9117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AdapterView.staticClass, _performItemClick9117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemLongClickListener9118; 
		public virtual void setOnItemLongClickListener(android.widget.AdapterView.OnItemLongClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setOnItemLongClickListener9118, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setOnItemLongClickListener9118, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemLongClickListener9119; 
		public virtual android.widget.AdapterView.OnItemLongClickListener getOnItemLongClickListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemLongClickListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnItemLongClickListener9119)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemLongClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AdapterView.staticClass, _getOnItemLongClickListener9119)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemSelectedListener9120; 
		public virtual android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnItemSelectedListener9120)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AdapterView.staticClass, _getOnItemSelectedListener9120)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter9121; 
		public abstract android.widget.Adapter getAdapter(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItemPosition9122; 
		public virtual int getSelectedItemPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallIntMethod(this, _getSelectedItemPosition9122); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AdapterView.staticClass, _getSelectedItemPosition9122); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItemId9123; 
		public virtual long getSelectedItemId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallLongMethod(this, _getSelectedItemId9123); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.AdapterView.staticClass, _getSelectedItemId9123); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedView9124; 
		public abstract android.view.View getSelectedView(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItem9125; 
		public virtual java.lang.Object getSelectedItem() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getSelectedItem9125)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AdapterView.staticClass, _getSelectedItem9125)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositionForView9126; 
		public virtual int getPositionForView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallIntMethod(this, _getPositionForView9126, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AdapterView.staticClass, _getPositionForView9126, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFirstVisiblePosition9127; 
		public virtual int getFirstVisiblePosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallIntMethod(this, _getFirstVisiblePosition9127); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AdapterView.staticClass, _getFirstVisiblePosition9127); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLastVisiblePosition9128; 
		public virtual int getLastVisiblePosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallIntMethod(this, _getLastVisiblePosition9128); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AdapterView.staticClass, _getLastVisiblePosition9128); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9129; 
		public abstract void setSelection(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setEmptyView9130; 
		public virtual void setEmptyView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setEmptyView9130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setEmptyView9130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEmptyView9131; 
		public virtual android.view.View getEmptyView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getEmptyView9131)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AdapterView.staticClass, _getEmptyView9131)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemAtPosition9132; 
		public virtual java.lang.Object getItemAtPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getItemAtPosition9132, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AdapterView.staticClass, _getItemAtPosition9132, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemIdAtPosition9133; 
		public virtual long getItemIdAtPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallLongMethod(this, _getItemIdAtPosition9133, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.AdapterView.staticClass, _getItemIdAtPosition9133, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AdapterView9134; 
		public AdapterView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AdapterView.staticClass, _AdapterView9134, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AdapterView9135; 
		public AdapterView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AdapterView.staticClass, _AdapterView9135, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AdapterView9136; 
		public AdapterView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AdapterView.staticClass, _AdapterView9136, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int ITEM_VIEW_TYPE_IGNORE
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		public static int ITEM_VIEW_TYPE_HEADER_OR_FOOTER
		{ 
			get 
			{ 
				return -2; 
			} 
		} 
		public static int INVALID_POSITION
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		public static long INVALID_ROW_ID
		{ 
			get 
			{ 
				return -9223372036854775808L; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.AdapterView.staticClass = @__class; 
			global::android.widget.AdapterView._dispatchPopulateAccessibilityEvent9097 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.widget.AdapterView._addView9098 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.AdapterView._addView9099 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;)V"); 
			global::android.widget.AdapterView._addView9100 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;I)V"); 
			global::android.widget.AdapterView._addView9101 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.AdapterView._removeView9102 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "removeView", "(Landroid/view/View;)V"); 
			global::android.widget.AdapterView._setOnClickListener9103 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V"); 
			global::android.widget.AdapterView._setFocusable9104 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setFocusable", "(Z)V"); 
			global::android.widget.AdapterView._setFocusableInTouchMode9105 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setFocusableInTouchMode", "(Z)V"); 
			global::android.widget.AdapterView._dispatchSaveInstanceState9106 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.widget.AdapterView._dispatchRestoreInstanceState9107 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.widget.AdapterView._onLayout9108 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.AdapterView._getCount9109 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getCount", "()I"); 
			global::android.widget.AdapterView._removeViewAt9110 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "removeViewAt", "(I)V"); 
			global::android.widget.AdapterView._removeAllViews9111 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "removeAllViews", "()V"); 
			global::android.widget.AdapterView._canAnimate9112 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "canAnimate", "()Z"); 
			global::android.widget.AdapterView._setAdapter9113 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V"); 
			global::android.widget.AdapterView._setOnItemSelectedListener9114 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V"); 
			global::android.widget.AdapterView._setOnItemClickListener9115 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V"); 
			global::android.widget.AdapterView._getOnItemClickListener9116 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;"); 
			global::android.widget.AdapterView._performItemClick9117 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z"); 
			global::android.widget.AdapterView._setOnItemLongClickListener9118 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setOnItemLongClickListener", "(Landroid/widget/AdapterView$OnItemLongClickListener;)V"); 
			global::android.widget.AdapterView._getOnItemLongClickListener9119 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getOnItemLongClickListener", "()Landroid/widget/AdapterView$OnItemLongClickListener;"); 
			global::android.widget.AdapterView._getOnItemSelectedListener9120 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;"); 
			global::android.widget.AdapterView._getAdapter9121 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getAdapter", "()Landroid/widget/Adapter;"); 
			global::android.widget.AdapterView._getSelectedItemPosition9122 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getSelectedItemPosition", "()I"); 
			global::android.widget.AdapterView._getSelectedItemId9123 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getSelectedItemId", "()J"); 
			global::android.widget.AdapterView._getSelectedView9124 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getSelectedView", "()Landroid/view/View;"); 
			global::android.widget.AdapterView._getSelectedItem9125 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getSelectedItem", "()Ljava/lang/Object;"); 
			global::android.widget.AdapterView._getPositionForView9126 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getPositionForView", "(Landroid/view/View;)I"); 
			global::android.widget.AdapterView._getFirstVisiblePosition9127 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getFirstVisiblePosition", "()I"); 
			global::android.widget.AdapterView._getLastVisiblePosition9128 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getLastVisiblePosition", "()I"); 
			global::android.widget.AdapterView._setSelection9129 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setSelection", "(I)V"); 
			global::android.widget.AdapterView._setEmptyView9130 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setEmptyView", "(Landroid/view/View;)V"); 
			global::android.widget.AdapterView._getEmptyView9131 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getEmptyView", "()Landroid/view/View;"); 
			global::android.widget.AdapterView._getItemAtPosition9132 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getItemAtPosition", "(I)Ljava/lang/Object;"); 
			global::android.widget.AdapterView._getItemIdAtPosition9133 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getItemIdAtPosition", "(I)J"); 
			global::android.widget.AdapterView._AdapterView9134 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.AdapterView._AdapterView9135 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.AdapterView._AdapterView9136 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
