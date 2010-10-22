namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.AdapterView_))]
	public abstract partial class AdapterView : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AdapterView()
		{
			InitJNI();
		}
		protected AdapterView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AdapterContextMenuInfo : java.lang.Object, android.view.ContextMenu_ContextMenuInfo
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AdapterContextMenuInfo()
			{
				InitJNI();
			}
			protected AdapterContextMenuInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _AdapterContextMenuInfo16536;
			public AdapterContextMenuInfo(android.view.View arg0, int arg1, long arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.AdapterContextMenuInfo.staticClass, global::android.widget.AdapterView.AdapterContextMenuInfo._AdapterContextMenuInfo16536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _targetView16537;
			public global::android.view.View targetView
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _targetView16537)) as android.view.View;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _position16538;
			public int position
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _position16538);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _id16539;
			public long id
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _id16539);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView$AdapterContextMenuInfo"));
				global::android.widget.AdapterView.AdapterContextMenuInfo._AdapterContextMenuInfo16536 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;IJ)V");
				global::android.widget.AdapterView.AdapterContextMenuInfo._targetView16537 = @__env.GetFieldIDNoThrow(global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass, "targetView", "Landroid/view/View;");
				global::android.widget.AdapterView.AdapterContextMenuInfo._position16538 = @__env.GetFieldIDNoThrow(global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass, "position", "I");
				global::android.widget.AdapterView.AdapterContextMenuInfo._id16539 = @__env.GetFieldIDNoThrow(global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass, "id", "J");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AdapterView.OnItemClickListener_))]
		public partial interface OnItemClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AdapterView.OnItemClickListener))]
		public sealed partial class OnItemClickListener_ : java.lang.Object, OnItemClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnItemClickListener_()
			{
				InitJNI();
			}
			internal OnItemClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onItemClick16540;
			 void android.widget.AdapterView.OnItemClickListener.onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemClickListener_._onItemClick16540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemClickListener_.staticClass, global::android.widget.AdapterView.OnItemClickListener_._onItemClick16540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.OnItemClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView$OnItemClickListener"));
				global::android.widget.AdapterView.OnItemClickListener_._onItemClick16540 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.OnItemClickListener_.staticClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AdapterView.OnItemLongClickListener_))]
		public partial interface OnItemLongClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onItemLongClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AdapterView.OnItemLongClickListener))]
		public sealed partial class OnItemLongClickListener_ : java.lang.Object, OnItemLongClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnItemLongClickListener_()
			{
				InitJNI();
			}
			internal OnItemLongClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onItemLongClick16541;
			 bool android.widget.AdapterView.OnItemLongClickListener.onItemLongClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemLongClickListener_._onItemLongClick16541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemLongClickListener_.staticClass, global::android.widget.AdapterView.OnItemLongClickListener_._onItemLongClick16541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.OnItemLongClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView$OnItemLongClickListener"));
				global::android.widget.AdapterView.OnItemLongClickListener_._onItemLongClick16541 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.OnItemLongClickListener_.staticClass, "onItemLongClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AdapterView.OnItemSelectedListener_))]
		public partial interface OnItemSelectedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onItemSelected(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3);
			void onNothingSelected(android.widget.AdapterView arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AdapterView.OnItemSelectedListener))]
		public sealed partial class OnItemSelectedListener_ : java.lang.Object, OnItemSelectedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnItemSelectedListener_()
			{
				InitJNI();
			}
			internal OnItemSelectedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onItemSelected16542;
			 void android.widget.AdapterView.OnItemSelectedListener.onItemSelected(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemSelectedListener_._onItemSelected16542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemSelectedListener_.staticClass, global::android.widget.AdapterView.OnItemSelectedListener_._onItemSelected16542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onNothingSelected16543;
			 void android.widget.AdapterView.OnItemSelectedListener.onNothingSelected(android.widget.AdapterView arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemSelectedListener_._onNothingSelected16543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemSelectedListener_.staticClass, global::android.widget.AdapterView.OnItemSelectedListener_._onNothingSelected16543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.OnItemSelectedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView$OnItemSelectedListener"));
				global::android.widget.AdapterView.OnItemSelectedListener_._onItemSelected16542 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.OnItemSelectedListener_.staticClass, "onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
				global::android.widget.AdapterView.OnItemSelectedListener_._onNothingSelected16543 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.OnItemSelectedListener_.staticClass, "onNothingSelected", "(Landroid/widget/AdapterView;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent16544;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AdapterView._dispatchPopulateAccessibilityEvent16544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._dispatchPopulateAccessibilityEvent16544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView16545;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._addView16545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._addView16545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addView16546;
		public override void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._addView16546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._addView16546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView16547;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._addView16547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._addView16547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView16548;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._addView16548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._addView16548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeView16549;
		public override void removeView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._removeView16549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._removeView16549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnClickListener16550;
		public override void setOnClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setOnClickListener16550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setOnClickListener16550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable16551;
		public override void setFocusable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setFocusable16551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setFocusable16551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusableInTouchMode16552;
		public override void setFocusableInTouchMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setFocusableInTouchMode16552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setFocusableInTouchMode16552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState16553;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._dispatchSaveInstanceState16553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._dispatchSaveInstanceState16553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState16554;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._dispatchRestoreInstanceState16554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._dispatchRestoreInstanceState16554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout16555;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._onLayout16555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._onLayout16555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getCount16556;
		public virtual int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AdapterView._getCount16556);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getCount16556);
		}
		internal static global::MonoJavaBridge.MethodId _removeViewAt16557;
		public override void removeViewAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._removeViewAt16557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._removeViewAt16557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews16558;
		public override void removeAllViews() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._removeAllViews16558);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._removeAllViews16558);
		}
		internal static global::MonoJavaBridge.MethodId _canAnimate16559;
		protected override bool canAnimate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AdapterView._canAnimate16559);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._canAnimate16559);
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter16560;
		public abstract void setAdapter(android.widget.Adapter arg0);
		internal static global::MonoJavaBridge.MethodId _setOnItemSelectedListener16561;
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setOnItemSelectedListener16561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setOnItemSelectedListener16561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemClickListener16562;
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setOnItemClickListener16562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setOnItemClickListener16562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnItemClickListener16563;
		public virtual global::android.widget.AdapterView.OnItemClickListener getOnItemClickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemClickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView._getOnItemClickListener16563)) as android.widget.AdapterView.OnItemClickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemClickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getOnItemClickListener16563)) as android.widget.AdapterView.OnItemClickListener;
		}
		internal static global::MonoJavaBridge.MethodId _performItemClick16564;
		public virtual bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AdapterView._performItemClick16564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._performItemClick16564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemLongClickListener16565;
		public virtual void setOnItemLongClickListener(android.widget.AdapterView.OnItemLongClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setOnItemLongClickListener16565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setOnItemLongClickListener16565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnItemLongClickListener16566;
		public virtual global::android.widget.AdapterView.OnItemLongClickListener getOnItemLongClickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemLongClickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView._getOnItemLongClickListener16566)) as android.widget.AdapterView.OnItemLongClickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemLongClickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getOnItemLongClickListener16566)) as android.widget.AdapterView.OnItemLongClickListener;
		}
		internal static global::MonoJavaBridge.MethodId _getOnItemSelectedListener16567;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemSelectedListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView._getOnItemSelectedListener16567)) as android.widget.AdapterView.OnItemSelectedListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemSelectedListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getOnItemSelectedListener16567)) as android.widget.AdapterView.OnItemSelectedListener;
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter16568;
		public abstract global::android.widget.Adapter getAdapter();
		internal static global::MonoJavaBridge.MethodId _getSelectedItemPosition16569;
		public virtual int getSelectedItemPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AdapterView._getSelectedItemPosition16569);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getSelectedItemPosition16569);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedItemId16570;
		public virtual long getSelectedItemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.AdapterView._getSelectedItemId16570);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getSelectedItemId16570);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedView16571;
		public abstract global::android.view.View getSelectedView();
		internal static global::MonoJavaBridge.MethodId _getSelectedItem16572;
		public virtual global::java.lang.Object getSelectedItem() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView._getSelectedItem16572)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getSelectedItem16572)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionForView16573;
		public virtual int getPositionForView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AdapterView._getPositionForView16573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getPositionForView16573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstVisiblePosition16574;
		public virtual int getFirstVisiblePosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AdapterView._getFirstVisiblePosition16574);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getFirstVisiblePosition16574);
		}
		internal static global::MonoJavaBridge.MethodId _getLastVisiblePosition16575;
		public virtual int getLastVisiblePosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AdapterView._getLastVisiblePosition16575);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getLastVisiblePosition16575);
		}
		internal static global::MonoJavaBridge.MethodId _setSelection16576;
		public abstract void setSelection(int arg0);
		internal static global::MonoJavaBridge.MethodId _setEmptyView16577;
		public virtual void setEmptyView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setEmptyView16577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setEmptyView16577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEmptyView16578;
		public virtual global::android.view.View getEmptyView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView._getEmptyView16578)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getEmptyView16578)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemAtPosition16579;
		public virtual global::java.lang.Object getItemAtPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView._getItemAtPosition16579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getItemAtPosition16579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemIdAtPosition16580;
		public virtual long getItemIdAtPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.AdapterView._getItemIdAtPosition16580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getItemIdAtPosition16580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AdapterView16581;
		public AdapterView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.staticClass, global::android.widget.AdapterView._AdapterView16581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AdapterView16582;
		public AdapterView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.staticClass, global::android.widget.AdapterView._AdapterView16582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AdapterView16583;
		public AdapterView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.staticClass, global::android.widget.AdapterView._AdapterView16583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AdapterView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView"));
			global::android.widget.AdapterView._dispatchPopulateAccessibilityEvent16544 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.AdapterView._addView16545 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.AdapterView._addView16546 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.AdapterView._addView16547 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.AdapterView._addView16548 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.AdapterView._removeView16549 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "removeView", "(Landroid/view/View;)V");
			global::android.widget.AdapterView._setOnClickListener16550 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.AdapterView._setFocusable16551 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setFocusable", "(Z)V");
			global::android.widget.AdapterView._setFocusableInTouchMode16552 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setFocusableInTouchMode", "(Z)V");
			global::android.widget.AdapterView._dispatchSaveInstanceState16553 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.widget.AdapterView._dispatchRestoreInstanceState16554 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.widget.AdapterView._onLayout16555 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.AdapterView._getCount16556 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getCount", "()I");
			global::android.widget.AdapterView._removeViewAt16557 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "removeViewAt", "(I)V");
			global::android.widget.AdapterView._removeAllViews16558 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "removeAllViews", "()V");
			global::android.widget.AdapterView._canAnimate16559 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "canAnimate", "()Z");
			global::android.widget.AdapterView._setAdapter16560 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.AdapterView._setOnItemSelectedListener16561 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V");
			global::android.widget.AdapterView._setOnItemClickListener16562 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.AdapterView._getOnItemClickListener16563 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
			global::android.widget.AdapterView._performItemClick16564 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.AdapterView._setOnItemLongClickListener16565 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setOnItemLongClickListener", "(Landroid/widget/AdapterView$OnItemLongClickListener;)V");
			global::android.widget.AdapterView._getOnItemLongClickListener16566 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getOnItemLongClickListener", "()Landroid/widget/AdapterView$OnItemLongClickListener;");
			global::android.widget.AdapterView._getOnItemSelectedListener16567 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
			global::android.widget.AdapterView._getAdapter16568 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.AdapterView._getSelectedItemPosition16569 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getSelectedItemPosition", "()I");
			global::android.widget.AdapterView._getSelectedItemId16570 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getSelectedItemId", "()J");
			global::android.widget.AdapterView._getSelectedView16571 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AdapterView._getSelectedItem16572 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getSelectedItem", "()Ljava/lang/Object;");
			global::android.widget.AdapterView._getPositionForView16573 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getPositionForView", "(Landroid/view/View;)I");
			global::android.widget.AdapterView._getFirstVisiblePosition16574 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getFirstVisiblePosition", "()I");
			global::android.widget.AdapterView._getLastVisiblePosition16575 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getLastVisiblePosition", "()I");
			global::android.widget.AdapterView._setSelection16576 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setSelection", "(I)V");
			global::android.widget.AdapterView._setEmptyView16577 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setEmptyView", "(Landroid/view/View;)V");
			global::android.widget.AdapterView._getEmptyView16578 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getEmptyView", "()Landroid/view/View;");
			global::android.widget.AdapterView._getItemAtPosition16579 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getItemAtPosition", "(I)Ljava/lang/Object;");
			global::android.widget.AdapterView._getItemIdAtPosition16580 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getItemIdAtPosition", "(I)J");
			global::android.widget.AdapterView._AdapterView16581 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AdapterView._AdapterView16582 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AdapterView._AdapterView16583 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AdapterView))]
	public sealed partial class AdapterView_ : android.widget.AdapterView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AdapterView_()
		{
			InitJNI();
		}
		internal AdapterView_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter16588;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView_._setAdapter16588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView_.staticClass, global::android.widget.AdapterView_._setAdapter16588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter16589;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView_._getAdapter16589)) as android.widget.Adapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView_.staticClass, global::android.widget.AdapterView_._getAdapter16589)) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedView16590;
		public override global::android.view.View getSelectedView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView_._getSelectedView16590)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView_.staticClass, global::android.widget.AdapterView_._getSelectedView16590)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection16591;
		public override void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView_._setSelection16591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView_.staticClass, global::android.widget.AdapterView_._setSelection16591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AdapterView_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView"));
			global::android.widget.AdapterView_._setAdapter16588 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView_.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.AdapterView_._getAdapter16589 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView_.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.AdapterView_._getSelectedView16590 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView_.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AdapterView_._setSelection16591 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView_.staticClass, "setSelection", "(I)V");
		}
	}
}
