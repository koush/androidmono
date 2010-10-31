namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExpandableListView : android.widget.ListView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExpandableListView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ExpandableListContextMenuInfo : java.lang.Object, android.view.ContextMenu_ContextMenuInfo
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ExpandableListContextMenuInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public ExpandableListContextMenuInfo(android.view.View arg0, long arg1, long arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._m0.native == global::System.IntPtr.Zero)
					global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._m0 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;JJ)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _targetView6047;
			public global::android.view.View targetView
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _targetView6047)) as android.view.View;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _packedPosition6048;
			public long packedPosition
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _packedPosition6048);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _id6049;
			public long id
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _id6049);
				}
				set
				{
				}
			}
			static ExpandableListContextMenuInfo()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$ExpandableListContextMenuInfo"));
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._targetView6047 = @__env.GetFieldIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "targetView", "Landroid/view/View;");
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._packedPosition6048 = @__env.GetFieldIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "packedPosition", "J");
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._id6049 = @__env.GetFieldIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "id", "J");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnChildClickListener_))]
		public partial interface OnChildClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnChildClickListener))]
		internal sealed partial class OnChildClickListener_ : java.lang.Object, OnChildClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnChildClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.widget.ExpandableListView.OnChildClickListener.onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListView.OnChildClickListener_.staticClass, "onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z", ref global::android.widget.ExpandableListView.OnChildClickListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			static OnChildClickListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnChildClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnChildClickListener"));
			}
		}

		public delegate bool OnChildClickListenerDelegate(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4);

		internal partial class OnChildClickListenerDelegateWrapper : java.lang.Object, OnChildClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnChildClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnChildClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper.staticClass, global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnChildClickListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView_OnChildClickListenerDelegateWrapper"));
			}
		}
		internal partial class OnChildClickListenerDelegateWrapper
		{
			private OnChildClickListenerDelegate myDelegate;
			public bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4)
			{
				return myDelegate(arg0, arg1, arg2, arg3, arg4);
			}
			public static implicit operator OnChildClickListenerDelegateWrapper(OnChildClickListenerDelegate d)
			{
				global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper ret = new global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnGroupClickListener_))]
		public partial interface OnGroupClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnGroupClickListener))]
		internal sealed partial class OnGroupClickListener_ : java.lang.Object, OnGroupClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnGroupClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.widget.ExpandableListView.OnGroupClickListener.onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListView.OnGroupClickListener_.staticClass, "onGroupClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IJ)Z", ref global::android.widget.ExpandableListView.OnGroupClickListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			static OnGroupClickListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnGroupClickListener"));
			}
		}

		public delegate bool OnGroupClickListenerDelegate(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3);

		internal partial class OnGroupClickListenerDelegateWrapper : java.lang.Object, OnGroupClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnGroupClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnGroupClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper.staticClass, global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnGroupClickListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView_OnGroupClickListenerDelegateWrapper"));
			}
		}
		internal partial class OnGroupClickListenerDelegateWrapper
		{
			private OnGroupClickListenerDelegate myDelegate;
			public bool onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3)
			{
				return myDelegate(arg0, arg1, arg2, arg3);
			}
			public static implicit operator OnGroupClickListenerDelegateWrapper(OnGroupClickListenerDelegate d)
			{
				global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper ret = new global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnGroupCollapseListener_))]
		public partial interface OnGroupCollapseListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGroupCollapse(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnGroupCollapseListener))]
		internal sealed partial class OnGroupCollapseListener_ : java.lang.Object, OnGroupCollapseListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnGroupCollapseListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.ExpandableListView.OnGroupCollapseListener.onGroupCollapse(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.OnGroupCollapseListener_.staticClass, "onGroupCollapse", "(I)V", ref global::android.widget.ExpandableListView.OnGroupCollapseListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnGroupCollapseListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupCollapseListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnGroupCollapseListener"));
			}
		}

		public delegate void OnGroupCollapseListenerDelegate(int arg0);

		internal partial class OnGroupCollapseListenerDelegateWrapper : java.lang.Object, OnGroupCollapseListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnGroupCollapseListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnGroupCollapseListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper.staticClass, global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnGroupCollapseListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView_OnGroupCollapseListenerDelegateWrapper"));
			}
		}
		internal partial class OnGroupCollapseListenerDelegateWrapper
		{
			private OnGroupCollapseListenerDelegate myDelegate;
			public void onGroupCollapse(int arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnGroupCollapseListenerDelegateWrapper(OnGroupCollapseListenerDelegate d)
			{
				global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper ret = new global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnGroupExpandListener_))]
		public partial interface OnGroupExpandListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGroupExpand(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnGroupExpandListener))]
		internal sealed partial class OnGroupExpandListener_ : java.lang.Object, OnGroupExpandListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnGroupExpandListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.ExpandableListView.OnGroupExpandListener.onGroupExpand(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.OnGroupExpandListener_.staticClass, "onGroupExpand", "(I)V", ref global::android.widget.ExpandableListView.OnGroupExpandListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnGroupExpandListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupExpandListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnGroupExpandListener"));
			}
		}

		public delegate void OnGroupExpandListenerDelegate(int arg0);

		internal partial class OnGroupExpandListenerDelegateWrapper : java.lang.Object, OnGroupExpandListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnGroupExpandListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnGroupExpandListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper.staticClass, global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnGroupExpandListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView_OnGroupExpandListenerDelegateWrapper"));
			}
		}
		internal partial class OnGroupExpandListenerDelegateWrapper
		{
			private OnGroupExpandListenerDelegate myDelegate;
			public void onGroupExpand(int arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnGroupExpandListenerDelegateWrapper(OnGroupExpandListenerDelegate d)
			{
				global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper ret = new global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.widget.ExpandableListView._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.ExpandableListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.widget.ExpandableListView._m1) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.ExpandableListView._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setAdapter(android.widget.ListAdapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V", ref global::android.widget.ExpandableListView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setAdapter(android.widget.ExpandableListAdapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ExpandableListAdapter;)V", ref global::android.widget.ExpandableListView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.AdapterView.OnItemClickListener OnItemClickListener
		{
			set
			{
				setOnItemClickListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", ref global::android.widget.ExpandableListView._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnItemClickListener(global::android.widget.AdapterView.OnItemClickListenerDelegate arg0)
		{
			setOnItemClickListener((global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z", ref global::android.widget.ExpandableListView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.widget.ListAdapter Adapter
		{
			get
			{
				return getAdapter();
			}
			set
			{
				setAdapter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.widget.ListAdapter getAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.ListAdapter>(this, global::android.widget.ExpandableListView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;", ref global::android.widget.ExpandableListView._m7) as android.widget.ListAdapter;
		}
		public new global::android.widget.ExpandableListAdapter ExpandableListAdapter
		{
			get
			{
				return getExpandableListAdapter();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.widget.ExpandableListAdapter getExpandableListAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.ExpandableListAdapter>(this, global::android.widget.ExpandableListView.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;", ref global::android.widget.ExpandableListView._m8) as android.widget.ExpandableListAdapter;
		}
		public new long SelectedId
		{
			get
			{
				return getSelectedId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual long getSelectedId()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ExpandableListView.staticClass, "getSelectedId", "()J", ref global::android.widget.ExpandableListView._m9);
		}
		public new long SelectedPosition
		{
			get
			{
				return getSelectedPosition();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual long getSelectedPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ExpandableListView.staticClass, "getSelectedPosition", "()J", ref global::android.widget.ExpandableListView._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, "setSelectedChild", "(IIZ)Z", ref global::android.widget.ExpandableListView._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int SelectedGroup
		{
			set
			{
				setSelectedGroup(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setSelectedGroup(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setSelectedGroup", "(I)V", ref global::android.widget.ExpandableListView._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable ChildDivider
		{
			set
			{
				setChildDivider(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setChildDivider(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setChildDivider", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.ExpandableListView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool expandGroup(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, "expandGroup", "(I)Z", ref global::android.widget.ExpandableListView._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool collapseGroup(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, "collapseGroup", "(I)Z", ref global::android.widget.ExpandableListView._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setOnGroupCollapseListener(android.widget.ExpandableListView.OnGroupCollapseListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setOnGroupCollapseListener", "(Landroid/widget/ExpandableListView$OnGroupCollapseListener;)V", ref global::android.widget.ExpandableListView._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnGroupCollapseListener(global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegate arg0)
		{
			setOnGroupCollapseListener((global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setOnGroupExpandListener(android.widget.ExpandableListView.OnGroupExpandListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setOnGroupExpandListener", "(Landroid/widget/ExpandableListView$OnGroupExpandListener;)V", ref global::android.widget.ExpandableListView._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnGroupExpandListener(global::android.widget.ExpandableListView.OnGroupExpandListenerDelegate arg0)
		{
			setOnGroupExpandListener((global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setOnGroupClickListener(android.widget.ExpandableListView.OnGroupClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setOnGroupClickListener", "(Landroid/widget/ExpandableListView$OnGroupClickListener;)V", ref global::android.widget.ExpandableListView._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnGroupClickListener(global::android.widget.ExpandableListView.OnGroupClickListenerDelegate arg0)
		{
			setOnGroupClickListener((global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setOnChildClickListener(android.widget.ExpandableListView.OnChildClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setOnChildClickListener", "(Landroid/widget/ExpandableListView$OnChildClickListener;)V", ref global::android.widget.ExpandableListView._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnChildClickListener(global::android.widget.ExpandableListView.OnChildClickListenerDelegate arg0)
		{
			setOnChildClickListener((global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual long getExpandableListPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ExpandableListView.staticClass, "getExpandableListPosition", "(I)J", ref global::android.widget.ExpandableListView._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int getFlatListPosition(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ExpandableListView.staticClass, "getFlatListPosition", "(J)I", ref global::android.widget.ExpandableListView._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool isGroupExpanded(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, "isGroupExpanded", "(I)Z", ref global::android.widget.ExpandableListView._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static int getPackedPositionType(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ExpandableListView._m23.native == global::System.IntPtr.Zero)
				global::android.widget.ExpandableListView._m23 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionType", "(J)I");
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static int getPackedPositionGroup(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ExpandableListView._m24.native == global::System.IntPtr.Zero)
				global::android.widget.ExpandableListView._m24 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionGroup", "(J)I");
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static int getPackedPositionChild(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ExpandableListView._m25.native == global::System.IntPtr.Zero)
				global::android.widget.ExpandableListView._m25 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionChild", "(J)I");
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static long getPackedPositionForChild(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ExpandableListView._m26.native == global::System.IntPtr.Zero)
				global::android.widget.ExpandableListView._m26 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForChild", "(II)J");
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static long getPackedPositionForGroup(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ExpandableListView._m27.native == global::System.IntPtr.Zero)
				global::android.widget.ExpandableListView._m27 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForGroup", "(I)J");
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable ChildIndicator
		{
			set
			{
				setChildIndicator(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setChildIndicator(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setChildIndicator", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.ExpandableListView._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void setChildIndicatorBounds(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setChildIndicatorBounds", "(II)V", ref global::android.widget.ExpandableListView._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.graphics.drawable.Drawable GroupIndicator
		{
			set
			{
				setGroupIndicator(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setGroupIndicator(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setGroupIndicator", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.ExpandableListView._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void setIndicatorBounds(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListView.staticClass, "setIndicatorBounds", "(II)V", ref global::android.widget.ExpandableListView._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ExpandableListView._m32.native == global::System.IntPtr.Zero)
				global::android.widget.ExpandableListView._m32 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ExpandableListView._m33.native == global::System.IntPtr.Zero)
				global::android.widget.ExpandableListView._m33 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public ExpandableListView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ExpandableListView._m34.native == global::System.IntPtr.Zero)
				global::android.widget.ExpandableListView._m34 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int PACKED_POSITION_TYPE_GROUP
		{
			get
			{
				return 0;
			}
		}
		public static int PACKED_POSITION_TYPE_CHILD
		{
			get
			{
				return 1;
			}
		}
		public static int PACKED_POSITION_TYPE_NULL
		{
			get
			{
				return 2;
			}
		}
		public static long PACKED_POSITION_VALUE_NULL
		{
			get
			{
				return 4294967295L;
			}
		}
		public static int CHILD_INDICATOR_INHERIT
		{
			get
			{
				return -1;
			}
		}
		static ExpandableListView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ExpandableListView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView"));
		}
	}
}
