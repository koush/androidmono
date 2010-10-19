namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExpandableListView : android.widget.ListView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExpandableListView()
		{
			InitJNI();
		}
		protected ExpandableListView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ExpandableListContextMenuInfo : java.lang.Object, android.view.ContextMenu_ContextMenuInfo
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ExpandableListContextMenuInfo()
			{
				InitJNI();
			}
			protected ExpandableListContextMenuInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ExpandableListContextMenuInfo11775;
			public ExpandableListContextMenuInfo(android.view.View arg0, long arg1, long arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._ExpandableListContextMenuInfo11775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _targetView11776;
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
			internal static global::MonoJavaBridge.FieldId _packedPosition11777;
			public long packedPosition
			{
				get
				{
					return default(long);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _id11778;
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
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$ExpandableListContextMenuInfo"));
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._ExpandableListContextMenuInfo11775 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;JJ)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnChildClickListener_))]
		public interface OnChildClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnChildClickListener))]
		public sealed partial class OnChildClickListener_ : java.lang.Object, OnChildClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnChildClickListener_()
			{
				InitJNI();
			}
			internal OnChildClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onChildClick11779;
			 bool android.widget.ExpandableListView.OnChildClickListener.onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnChildClickListener_._onChildClick11779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnChildClickListener_.staticClass, global::android.widget.ExpandableListView.OnChildClickListener_._onChildClick11779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnChildClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnChildClickListener"));
				global::android.widget.ExpandableListView.OnChildClickListener_._onChildClick11779 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnChildClickListener_.staticClass, "onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnGroupClickListener_))]
		public interface OnGroupClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnGroupClickListener))]
		public sealed partial class OnGroupClickListener_ : java.lang.Object, OnGroupClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGroupClickListener_()
			{
				InitJNI();
			}
			internal OnGroupClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGroupClick11780;
			 bool android.widget.ExpandableListView.OnGroupClickListener.onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupClickListener_._onGroupClick11780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupClickListener_.staticClass, global::android.widget.ExpandableListView.OnGroupClickListener_._onGroupClick11780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnGroupClickListener"));
				global::android.widget.ExpandableListView.OnGroupClickListener_._onGroupClick11780 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupClickListener_.staticClass, "onGroupClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IJ)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnGroupCollapseListener_))]
		public interface OnGroupCollapseListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGroupCollapse(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnGroupCollapseListener))]
		public sealed partial class OnGroupCollapseListener_ : java.lang.Object, OnGroupCollapseListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGroupCollapseListener_()
			{
				InitJNI();
			}
			internal OnGroupCollapseListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGroupCollapse11781;
			 void android.widget.ExpandableListView.OnGroupCollapseListener.onGroupCollapse(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupCollapseListener_._onGroupCollapse11781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupCollapseListener_.staticClass, global::android.widget.ExpandableListView.OnGroupCollapseListener_._onGroupCollapse11781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupCollapseListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnGroupCollapseListener"));
				global::android.widget.ExpandableListView.OnGroupCollapseListener_._onGroupCollapse11781 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupCollapseListener_.staticClass, "onGroupCollapse", "(I)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnGroupExpandListener_))]
		public interface OnGroupExpandListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGroupExpand(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnGroupExpandListener))]
		public sealed partial class OnGroupExpandListener_ : java.lang.Object, OnGroupExpandListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGroupExpandListener_()
			{
				InitJNI();
			}
			internal OnGroupExpandListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGroupExpand11782;
			 void android.widget.ExpandableListView.OnGroupExpandListener.onGroupExpand(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupExpandListener_._onGroupExpand11782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupExpandListener_.staticClass, global::android.widget.ExpandableListView.OnGroupExpandListener_._onGroupExpand11782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupExpandListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnGroupExpandListener"));
				global::android.widget.ExpandableListView.OnGroupExpandListener_._onGroupExpand11782 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupExpandListener_.staticClass, "onGroupExpand", "(I)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState11783;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._onRestoreInstanceState11783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._onRestoreInstanceState11783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState11784;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView._onSaveInstanceState11784)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._onSaveInstanceState11784)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw11785;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._dispatchDraw11785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._dispatchDraw11785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter11786;
		public override void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setAdapter11786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setAdapter11786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter11787;
		public virtual void setAdapter(android.widget.ExpandableListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setAdapter11787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setAdapter11787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemClickListener11788;
		public override void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnItemClickListener11788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnItemClickListener11788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performItemClick11789;
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._performItemClick11789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._performItemClick11789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		internal static global::MonoJavaBridge.MethodId _getAdapter11790;
		public virtual global::android.widget.ListAdapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView._getAdapter11790)) as android.widget.ListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getAdapter11790)) as android.widget.ListAdapter;
		}
		public new global::android.widget.ExpandableListAdapter ExpandableListAdapter
		{
			get
			{
				return getExpandableListAdapter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExpandableListAdapter11791;
		public virtual global::android.widget.ExpandableListAdapter getExpandableListAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ExpandableListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView._getExpandableListAdapter11791)) as android.widget.ExpandableListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ExpandableListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getExpandableListAdapter11791)) as android.widget.ExpandableListAdapter;
		}
		public new long SelectedId
		{
			get
			{
				return getSelectedId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedId11792;
		public virtual long getSelectedId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListView._getSelectedId11792);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getSelectedId11792);
		}
		public new long SelectedPosition
		{
			get
			{
				return getSelectedPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedPosition11793;
		public virtual long getSelectedPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListView._getSelectedPosition11793);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getSelectedPosition11793);
		}
		internal static global::MonoJavaBridge.MethodId _setSelectedChild11794;
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._setSelectedChild11794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setSelectedChild11794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setSelectedGroup11795;
		public virtual void setSelectedGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setSelectedGroup11795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setSelectedGroup11795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildDivider11796;
		public virtual void setChildDivider(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setChildDivider11796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildDivider11796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _expandGroup11797;
		public virtual bool expandGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._expandGroup11797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._expandGroup11797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _collapseGroup11798;
		public virtual bool collapseGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._collapseGroup11798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._collapseGroup11798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnGroupCollapseListener11799;
		public virtual void setOnGroupCollapseListener(android.widget.ExpandableListView.OnGroupCollapseListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnGroupCollapseListener11799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupCollapseListener11799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnGroupExpandListener11800;
		public virtual void setOnGroupExpandListener(android.widget.ExpandableListView.OnGroupExpandListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnGroupExpandListener11800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupExpandListener11800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnGroupClickListener11801;
		public virtual void setOnGroupClickListener(android.widget.ExpandableListView.OnGroupClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnGroupClickListener11801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupClickListener11801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnChildClickListener11802;
		public virtual void setOnChildClickListener(android.widget.ExpandableListView.OnChildClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnChildClickListener11802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnChildClickListener11802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExpandableListPosition11803;
		public virtual long getExpandableListPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListView._getExpandableListPosition11803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getExpandableListPosition11803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFlatListPosition11804;
		public virtual int getFlatListPosition(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ExpandableListView._getFlatListPosition11804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getFlatListPosition11804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isGroupExpanded11805;
		public virtual bool isGroupExpanded(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._isGroupExpanded11805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._isGroupExpanded11805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionType11806;
		public static int getPackedPositionType(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionType11806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionGroup11807;
		public static int getPackedPositionGroup(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionGroup11807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionChild11808;
		public static int getPackedPositionChild(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionChild11808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionForChild11809;
		public static long getPackedPositionForChild(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionForChild11809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionForGroup11810;
		public static long getPackedPositionForGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionForGroup11810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildIndicator11811;
		public virtual void setChildIndicator(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setChildIndicator11811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildIndicator11811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildIndicatorBounds11812;
		public virtual void setChildIndicatorBounds(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setChildIndicatorBounds11812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildIndicatorBounds11812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupIndicator11813;
		public virtual void setGroupIndicator(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setGroupIndicator11813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setGroupIndicator11813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIndicatorBounds11814;
		public virtual void setIndicatorBounds(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setIndicatorBounds11814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setIndicatorBounds11814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ExpandableListView11815;
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView11815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExpandableListView11816;
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView11816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExpandableListView11817;
		public ExpandableListView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView11817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ExpandableListView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView"));
			global::android.widget.ExpandableListView._onRestoreInstanceState11783 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ExpandableListView._onSaveInstanceState11784 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ExpandableListView._dispatchDraw11785 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ExpandableListView._setAdapter11786 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.ExpandableListView._setAdapter11787 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ExpandableListAdapter;)V");
			global::android.widget.ExpandableListView._setOnItemClickListener11788 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.ExpandableListView._performItemClick11789 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.ExpandableListView._getAdapter11790 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.ExpandableListView._getExpandableListAdapter11791 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;");
			global::android.widget.ExpandableListView._getSelectedId11792 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getSelectedId", "()J");
			global::android.widget.ExpandableListView._getSelectedPosition11793 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getSelectedPosition", "()J");
			global::android.widget.ExpandableListView._setSelectedChild11794 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setSelectedChild", "(IIZ)Z");
			global::android.widget.ExpandableListView._setSelectedGroup11795 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setSelectedGroup", "(I)V");
			global::android.widget.ExpandableListView._setChildDivider11796 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setChildDivider", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._expandGroup11797 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "expandGroup", "(I)Z");
			global::android.widget.ExpandableListView._collapseGroup11798 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "collapseGroup", "(I)Z");
			global::android.widget.ExpandableListView._setOnGroupCollapseListener11799 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnGroupCollapseListener", "(Landroid/widget/ExpandableListView$OnGroupCollapseListener;)V");
			global::android.widget.ExpandableListView._setOnGroupExpandListener11800 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnGroupExpandListener", "(Landroid/widget/ExpandableListView$OnGroupExpandListener;)V");
			global::android.widget.ExpandableListView._setOnGroupClickListener11801 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnGroupClickListener", "(Landroid/widget/ExpandableListView$OnGroupClickListener;)V");
			global::android.widget.ExpandableListView._setOnChildClickListener11802 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnChildClickListener", "(Landroid/widget/ExpandableListView$OnChildClickListener;)V");
			global::android.widget.ExpandableListView._getExpandableListPosition11803 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getExpandableListPosition", "(I)J");
			global::android.widget.ExpandableListView._getFlatListPosition11804 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getFlatListPosition", "(J)I");
			global::android.widget.ExpandableListView._isGroupExpanded11805 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "isGroupExpanded", "(I)Z");
			global::android.widget.ExpandableListView._getPackedPositionType11806 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionType", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionGroup11807 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionGroup", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionChild11808 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionChild", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionForChild11809 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForChild", "(II)J");
			global::android.widget.ExpandableListView._getPackedPositionForGroup11810 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForGroup", "(I)J");
			global::android.widget.ExpandableListView._setChildIndicator11811 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setChildIndicator", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._setChildIndicatorBounds11812 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setChildIndicatorBounds", "(II)V");
			global::android.widget.ExpandableListView._setGroupIndicator11813 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setGroupIndicator", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._setIndicatorBounds11814 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setIndicatorBounds", "(II)V");
			global::android.widget.ExpandableListView._ExpandableListView11815 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ExpandableListView._ExpandableListView11816 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ExpandableListView._ExpandableListView11817 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
