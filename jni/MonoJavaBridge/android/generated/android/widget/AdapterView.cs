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
			internal static global::MonoJavaBridge.MethodId _AdapterContextMenuInfo11395;
			public AdapterContextMenuInfo(android.view.View arg0, int arg1, long arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.AdapterContextMenuInfo.staticClass, global::android.widget.AdapterView.AdapterContextMenuInfo._AdapterContextMenuInfo11395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _targetView11396;
			public global::android.view.View targetView
			{
				get
				{
					return default(global::android.view.View);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _position11397;
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
			internal static global::MonoJavaBridge.FieldId _id11398;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView$AdapterContextMenuInfo"));
				global::android.widget.AdapterView.AdapterContextMenuInfo._AdapterContextMenuInfo11395 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;IJ)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AdapterView.OnItemClickListener_))]
		public interface OnItemClickListener  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _onItemClick11399;
			 void android.widget.AdapterView.OnItemClickListener.onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemClickListener_._onItemClick11399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemClickListener_.staticClass, global::android.widget.AdapterView.OnItemClickListener_._onItemClick11399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.OnItemClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView$OnItemClickListener"));
				global::android.widget.AdapterView.OnItemClickListener_._onItemClick11399 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.OnItemClickListener_.staticClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AdapterView.OnItemLongClickListener_))]
		public interface OnItemLongClickListener  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _onItemLongClick11400;
			 bool android.widget.AdapterView.OnItemLongClickListener.onItemLongClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemLongClickListener_._onItemLongClick11400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemLongClickListener_.staticClass, global::android.widget.AdapterView.OnItemLongClickListener_._onItemLongClick11400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.OnItemLongClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView$OnItemLongClickListener"));
				global::android.widget.AdapterView.OnItemLongClickListener_._onItemLongClick11400 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.OnItemLongClickListener_.staticClass, "onItemLongClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AdapterView.OnItemSelectedListener_))]
		public interface OnItemSelectedListener  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _onItemSelected11401;
			 void android.widget.AdapterView.OnItemSelectedListener.onItemSelected(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemSelectedListener_._onItemSelected11401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemSelectedListener_.staticClass, global::android.widget.AdapterView.OnItemSelectedListener_._onItemSelected11401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onNothingSelected11402;
			 void android.widget.AdapterView.OnItemSelectedListener.onNothingSelected(android.widget.AdapterView arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemSelectedListener_._onNothingSelected11402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.OnItemSelectedListener_.staticClass, global::android.widget.AdapterView.OnItemSelectedListener_._onNothingSelected11402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.OnItemSelectedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView$OnItemSelectedListener"));
				global::android.widget.AdapterView.OnItemSelectedListener_._onItemSelected11401 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.OnItemSelectedListener_.staticClass, "onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
				global::android.widget.AdapterView.OnItemSelectedListener_._onNothingSelected11402 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.OnItemSelectedListener_.staticClass, "onNothingSelected", "(Landroid/widget/AdapterView;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent11403;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AdapterView._dispatchPopulateAccessibilityEvent11403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._dispatchPopulateAccessibilityEvent11403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView11404;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._addView11404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._addView11404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addView11405;
		public override void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._addView11405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._addView11405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView11406;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._addView11406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._addView11406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView11407;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._addView11407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._addView11407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeView11408;
		public override void removeView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._removeView11408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._removeView11408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnClickListener11409;
		public override void setOnClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setOnClickListener11409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setOnClickListener11409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable11410;
		public override void setFocusable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setFocusable11410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setFocusable11410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusableInTouchMode11411;
		public override void setFocusableInTouchMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setFocusableInTouchMode11411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setFocusableInTouchMode11411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState11412;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._dispatchSaveInstanceState11412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._dispatchSaveInstanceState11412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState11413;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._dispatchRestoreInstanceState11413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._dispatchRestoreInstanceState11413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout11414;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._onLayout11414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._onLayout11414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getCount11415;
		public virtual int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AdapterView._getCount11415);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getCount11415);
		}
		internal static global::MonoJavaBridge.MethodId _removeViewAt11416;
		public override void removeViewAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._removeViewAt11416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._removeViewAt11416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews11417;
		public override void removeAllViews() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._removeAllViews11417);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._removeAllViews11417);
		}
		internal static global::MonoJavaBridge.MethodId _canAnimate11418;
		protected override bool canAnimate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AdapterView._canAnimate11418);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._canAnimate11418);
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter11419;
		public abstract void setAdapter(android.widget.Adapter arg0);
		internal static global::MonoJavaBridge.MethodId _setOnItemSelectedListener11420;
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setOnItemSelectedListener11420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setOnItemSelectedListener11420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemClickListener11421;
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setOnItemClickListener11421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setOnItemClickListener11421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnItemClickListener11422;
		public virtual global::android.widget.AdapterView.OnItemClickListener getOnItemClickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemClickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView._getOnItemClickListener11422)) as android.widget.AdapterView.OnItemClickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemClickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getOnItemClickListener11422)) as android.widget.AdapterView.OnItemClickListener;
		}
		internal static global::MonoJavaBridge.MethodId _performItemClick11423;
		public virtual bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AdapterView._performItemClick11423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._performItemClick11423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemLongClickListener11424;
		public virtual void setOnItemLongClickListener(android.widget.AdapterView.OnItemLongClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setOnItemLongClickListener11424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setOnItemLongClickListener11424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnItemLongClickListener11425;
		public virtual global::android.widget.AdapterView.OnItemLongClickListener getOnItemLongClickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemLongClickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView._getOnItemLongClickListener11425)) as android.widget.AdapterView.OnItemLongClickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemLongClickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getOnItemLongClickListener11425)) as android.widget.AdapterView.OnItemLongClickListener;
		}
		internal static global::MonoJavaBridge.MethodId _getOnItemSelectedListener11426;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemSelectedListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView._getOnItemSelectedListener11426)) as android.widget.AdapterView.OnItemSelectedListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemSelectedListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getOnItemSelectedListener11426)) as android.widget.AdapterView.OnItemSelectedListener;
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter11427;
		public abstract global::android.widget.Adapter getAdapter();
		internal static global::MonoJavaBridge.MethodId _getSelectedItemPosition11428;
		public virtual int getSelectedItemPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AdapterView._getSelectedItemPosition11428);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getSelectedItemPosition11428);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedItemId11429;
		public virtual long getSelectedItemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.AdapterView._getSelectedItemId11429);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getSelectedItemId11429);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedView11430;
		public abstract global::android.view.View getSelectedView();
		internal static global::MonoJavaBridge.MethodId _getSelectedItem11431;
		public virtual global::java.lang.Object getSelectedItem() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView._getSelectedItem11431)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getSelectedItem11431)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionForView11432;
		public virtual int getPositionForView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AdapterView._getPositionForView11432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getPositionForView11432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstVisiblePosition11433;
		public virtual int getFirstVisiblePosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AdapterView._getFirstVisiblePosition11433);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getFirstVisiblePosition11433);
		}
		internal static global::MonoJavaBridge.MethodId _getLastVisiblePosition11434;
		public virtual int getLastVisiblePosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AdapterView._getLastVisiblePosition11434);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getLastVisiblePosition11434);
		}
		internal static global::MonoJavaBridge.MethodId _setSelection11435;
		public abstract void setSelection(int arg0);
		internal static global::MonoJavaBridge.MethodId _setEmptyView11436;
		public virtual void setEmptyView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView._setEmptyView11436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setEmptyView11436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEmptyView11437;
		public virtual global::android.view.View getEmptyView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView._getEmptyView11437)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getEmptyView11437)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemAtPosition11438;
		public virtual global::java.lang.Object getItemAtPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView._getItemAtPosition11438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getItemAtPosition11438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemIdAtPosition11439;
		public virtual long getItemIdAtPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.AdapterView._getItemIdAtPosition11439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getItemIdAtPosition11439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AdapterView11440;
		public AdapterView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.staticClass, global::android.widget.AdapterView._AdapterView11440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AdapterView11441;
		public AdapterView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.staticClass, global::android.widget.AdapterView._AdapterView11441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AdapterView11442;
		public AdapterView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.staticClass, global::android.widget.AdapterView._AdapterView11442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.widget.AdapterView._dispatchPopulateAccessibilityEvent11403 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.AdapterView._addView11404 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.AdapterView._addView11405 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.AdapterView._addView11406 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.AdapterView._addView11407 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.AdapterView._removeView11408 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "removeView", "(Landroid/view/View;)V");
			global::android.widget.AdapterView._setOnClickListener11409 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.AdapterView._setFocusable11410 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setFocusable", "(Z)V");
			global::android.widget.AdapterView._setFocusableInTouchMode11411 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setFocusableInTouchMode", "(Z)V");
			global::android.widget.AdapterView._dispatchSaveInstanceState11412 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.widget.AdapterView._dispatchRestoreInstanceState11413 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.widget.AdapterView._onLayout11414 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.AdapterView._getCount11415 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getCount", "()I");
			global::android.widget.AdapterView._removeViewAt11416 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "removeViewAt", "(I)V");
			global::android.widget.AdapterView._removeAllViews11417 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "removeAllViews", "()V");
			global::android.widget.AdapterView._canAnimate11418 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "canAnimate", "()Z");
			global::android.widget.AdapterView._setAdapter11419 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.AdapterView._setOnItemSelectedListener11420 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V");
			global::android.widget.AdapterView._setOnItemClickListener11421 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.AdapterView._getOnItemClickListener11422 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
			global::android.widget.AdapterView._performItemClick11423 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.AdapterView._setOnItemLongClickListener11424 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setOnItemLongClickListener", "(Landroid/widget/AdapterView$OnItemLongClickListener;)V");
			global::android.widget.AdapterView._getOnItemLongClickListener11425 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getOnItemLongClickListener", "()Landroid/widget/AdapterView$OnItemLongClickListener;");
			global::android.widget.AdapterView._getOnItemSelectedListener11426 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
			global::android.widget.AdapterView._getAdapter11427 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.AdapterView._getSelectedItemPosition11428 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getSelectedItemPosition", "()I");
			global::android.widget.AdapterView._getSelectedItemId11429 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getSelectedItemId", "()J");
			global::android.widget.AdapterView._getSelectedView11430 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AdapterView._getSelectedItem11431 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getSelectedItem", "()Ljava/lang/Object;");
			global::android.widget.AdapterView._getPositionForView11432 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getPositionForView", "(Landroid/view/View;)I");
			global::android.widget.AdapterView._getFirstVisiblePosition11433 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getFirstVisiblePosition", "()I");
			global::android.widget.AdapterView._getLastVisiblePosition11434 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getLastVisiblePosition", "()I");
			global::android.widget.AdapterView._setSelection11435 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setSelection", "(I)V");
			global::android.widget.AdapterView._setEmptyView11436 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "setEmptyView", "(Landroid/view/View;)V");
			global::android.widget.AdapterView._getEmptyView11437 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getEmptyView", "()Landroid/view/View;");
			global::android.widget.AdapterView._getItemAtPosition11438 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getItemAtPosition", "(I)Ljava/lang/Object;");
			global::android.widget.AdapterView._getItemIdAtPosition11439 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "getItemIdAtPosition", "(I)J");
			global::android.widget.AdapterView._AdapterView11440 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AdapterView._AdapterView11441 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AdapterView._AdapterView11442 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;)V");
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
		internal static global::MonoJavaBridge.MethodId _setAdapter11443;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView_._setAdapter11443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView_.staticClass, global::android.widget.AdapterView_._setAdapter11443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter11444;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView_._getAdapter11444)) as android.widget.Adapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView_.staticClass, global::android.widget.AdapterView_._getAdapter11444)) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedView11445;
		public override global::android.view.View getSelectedView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AdapterView_._getSelectedView11445)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AdapterView_.staticClass, global::android.widget.AdapterView_._getSelectedView11445)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection11446;
		public override void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AdapterView_._setSelection11446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AdapterView_.staticClass, global::android.widget.AdapterView_._setSelection11446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AdapterView_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView"));
			global::android.widget.AdapterView_._setAdapter11443 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView_.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.AdapterView_._getAdapter11444 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView_.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.AdapterView_._getSelectedView11445 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView_.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AdapterView_._setSelection11446 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView_.staticClass, "setSelection", "(I)V");
		}
	}
}
