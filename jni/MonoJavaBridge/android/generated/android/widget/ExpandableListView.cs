namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ExpandableListView : android.widget.ListView
	{
		internal new static global::java.lang.Class staticClass;
		static ExpandableListView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ExpandableListView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ExpandableListView(@__env);
			}
		}
		protected ExpandableListView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class ExpandableListContextMenuInfo : java.lang.Object, android.view.ContextMenu_ContextMenuInfo
		{
			internal static global::java.lang.Class staticClass;
			static ExpandableListContextMenuInfo()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ExpandableListView.ExpandableListContextMenuInfo(@__env);
				}
			}
			protected ExpandableListContextMenuInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _ExpandableListContextMenuInfo10150;
			public ExpandableListContextMenuInfo(android.view.View arg0, long arg1, long arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._ExpandableListContextMenuInfo10150, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.FieldId _targetView10151;
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
			internal static global::net.sf.jni4net.jni.FieldId _packedPosition10152;
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
			internal static global::net.sf.jni4net.jni.FieldId _id10153;
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
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass = @__class;
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._ExpandableListContextMenuInfo10150 = @__env.GetMethodID(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;JJ)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnChildClickListener 
		{
			bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4);
		}

		public partial class OnChildClickListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnChildClickListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnChildClickListener : java.lang.Object, OnChildClickListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnChildClickListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ExpandableListView.__OnChildClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ExpandableListView.__OnChildClickListener(@__env);
				}
			}
			internal __OnChildClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onChildClick10154;
			 bool android.widget.ExpandableListView.OnChildClickListener.onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView.__OnChildClickListener._onChildClick10154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.__OnChildClickListener.staticClass, global::android.widget.ExpandableListView.__OnChildClickListener._onChildClick10154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ExpandableListView.__OnChildClickListener.staticClass = @__class;
				global::android.widget.ExpandableListView.__OnChildClickListener._onChildClick10154 = @__env.GetMethodID(global::android.widget.ExpandableListView.__OnChildClickListener.staticClass, "android.widget.ExpandableListView.OnChildClickListener.onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnGroupClickListener 
		{
			bool onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3);
		}

		public partial class OnGroupClickListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnGroupClickListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnGroupClickListener : java.lang.Object, OnGroupClickListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnGroupClickListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ExpandableListView.__OnGroupClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ExpandableListView.__OnGroupClickListener(@__env);
				}
			}
			internal __OnGroupClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGroupClick10155;
			 bool android.widget.ExpandableListView.OnGroupClickListener.onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView.__OnGroupClickListener._onGroupClick10155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.__OnGroupClickListener.staticClass, global::android.widget.ExpandableListView.__OnGroupClickListener._onGroupClick10155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ExpandableListView.__OnGroupClickListener.staticClass = @__class;
				global::android.widget.ExpandableListView.__OnGroupClickListener._onGroupClick10155 = @__env.GetMethodID(global::android.widget.ExpandableListView.__OnGroupClickListener.staticClass, "android.widget.ExpandableListView.OnGroupClickListener.onGroupClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IJ)Z");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnGroupCollapseListener 
		{
			void onGroupCollapse(int arg0);
		}

		public partial class OnGroupCollapseListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnGroupCollapseListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnGroupCollapseListener : java.lang.Object, OnGroupCollapseListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnGroupCollapseListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ExpandableListView.__OnGroupCollapseListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ExpandableListView.__OnGroupCollapseListener(@__env);
				}
			}
			internal __OnGroupCollapseListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGroupCollapse10156;
			 void android.widget.ExpandableListView.OnGroupCollapseListener.onGroupCollapse(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.ExpandableListView.__OnGroupCollapseListener._onGroupCollapse10156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.__OnGroupCollapseListener.staticClass, global::android.widget.ExpandableListView.__OnGroupCollapseListener._onGroupCollapse10156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ExpandableListView.__OnGroupCollapseListener.staticClass = @__class;
				global::android.widget.ExpandableListView.__OnGroupCollapseListener._onGroupCollapse10156 = @__env.GetMethodID(global::android.widget.ExpandableListView.__OnGroupCollapseListener.staticClass, "android.widget.ExpandableListView.OnGroupCollapseListener.onGroupCollapse", "(I)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnGroupExpandListener 
		{
			void onGroupExpand(int arg0);
		}

		public partial class OnGroupExpandListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnGroupExpandListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnGroupExpandListener : java.lang.Object, OnGroupExpandListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnGroupExpandListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ExpandableListView.__OnGroupExpandListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ExpandableListView.__OnGroupExpandListener(@__env);
				}
			}
			internal __OnGroupExpandListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGroupExpand10157;
			 void android.widget.ExpandableListView.OnGroupExpandListener.onGroupExpand(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.ExpandableListView.__OnGroupExpandListener._onGroupExpand10157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.__OnGroupExpandListener.staticClass, global::android.widget.ExpandableListView.__OnGroupExpandListener._onGroupExpand10157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ExpandableListView.__OnGroupExpandListener.staticClass = @__class;
				global::android.widget.ExpandableListView.__OnGroupExpandListener._onGroupExpand10157 = @__env.GetMethodID(global::android.widget.ExpandableListView.__OnGroupExpandListener.staticClass, "android.widget.ExpandableListView.OnGroupExpandListener.onGroupExpand", "(I)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState10158;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._onRestoreInstanceState10158, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._onRestoreInstanceState10158, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState10159;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ExpandableListView._onSaveInstanceState10159));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._onSaveInstanceState10159));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw10160;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._dispatchDraw10160, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._dispatchDraw10160, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter10161;
		public override void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setAdapter10161, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setAdapter10161, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter10162;
		public virtual void setAdapter(android.widget.ExpandableListAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setAdapter10162, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setAdapter10162, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemClickListener10163;
		public override void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setOnItemClickListener10163, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnItemClickListener10163, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performItemClick10164;
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView._performItemClick10164, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._performItemClick10164, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter10165;
		public virtual new global::android.widget.ListAdapter getAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ExpandableListView._getAdapter10165));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getAdapter10165));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExpandableListAdapter10166;
		public virtual global::android.widget.ExpandableListAdapter getExpandableListAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ExpandableListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ExpandableListView._getExpandableListAdapter10166));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ExpandableListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getExpandableListAdapter10166));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedId10167;
		public virtual long getSelectedId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.ExpandableListView._getSelectedId10167);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getSelectedId10167);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedPosition10168;
		public virtual long getSelectedPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.ExpandableListView._getSelectedPosition10168);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getSelectedPosition10168);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectedChild10169;
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView._setSelectedChild10169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setSelectedChild10169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectedGroup10170;
		public virtual void setSelectedGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setSelectedGroup10170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setSelectedGroup10170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChildDivider10171;
		public virtual void setChildDivider(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setChildDivider10171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildDivider10171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _expandGroup10172;
		public virtual bool expandGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView._expandGroup10172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._expandGroup10172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _collapseGroup10173;
		public virtual bool collapseGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView._collapseGroup10173, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._collapseGroup10173, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnGroupCollapseListener10174;
		public virtual void setOnGroupCollapseListener(android.widget.ExpandableListView.OnGroupCollapseListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setOnGroupCollapseListener10174, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupCollapseListener10174, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnGroupExpandListener10175;
		public virtual void setOnGroupExpandListener(android.widget.ExpandableListView.OnGroupExpandListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setOnGroupExpandListener10175, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupExpandListener10175, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnGroupClickListener10176;
		public virtual void setOnGroupClickListener(android.widget.ExpandableListView.OnGroupClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setOnGroupClickListener10176, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupClickListener10176, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnChildClickListener10177;
		public virtual void setOnChildClickListener(android.widget.ExpandableListView.OnChildClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setOnChildClickListener10177, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnChildClickListener10177, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExpandableListPosition10178;
		public virtual long getExpandableListPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.ExpandableListView._getExpandableListPosition10178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getExpandableListPosition10178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFlatListPosition10179;
		public virtual int getFlatListPosition(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ExpandableListView._getFlatListPosition10179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getFlatListPosition10179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isGroupExpanded10180;
		public virtual bool isGroupExpanded(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView._isGroupExpanded10180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._isGroupExpanded10180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionType10181;
		public static int getPackedPositionType(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionType10181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionGroup10182;
		public static int getPackedPositionGroup(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionGroup10182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionChild10183;
		public static int getPackedPositionChild(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionChild10183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionForChild10184;
		public static long getPackedPositionForChild(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionForChild10184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionForGroup10185;
		public static long getPackedPositionForGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionForGroup10185, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChildIndicator10186;
		public virtual void setChildIndicator(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setChildIndicator10186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildIndicator10186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChildIndicatorBounds10187;
		public virtual void setChildIndicatorBounds(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setChildIndicatorBounds10187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildIndicatorBounds10187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupIndicator10188;
		public virtual void setGroupIndicator(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setGroupIndicator10188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setGroupIndicator10188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIndicatorBounds10189;
		public virtual void setIndicatorBounds(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setIndicatorBounds10189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setIndicatorBounds10189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ExpandableListView10190;
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView10190, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ExpandableListView10191;
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView10191, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ExpandableListView10192;
		public ExpandableListView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView10192, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ExpandableListView.staticClass = @__class;
			global::android.widget.ExpandableListView._onRestoreInstanceState10158 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ExpandableListView._onSaveInstanceState10159 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ExpandableListView._dispatchDraw10160 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ExpandableListView._setAdapter10161 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.ExpandableListView._setAdapter10162 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ExpandableListAdapter;)V");
			global::android.widget.ExpandableListView._setOnItemClickListener10163 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.ExpandableListView._performItemClick10164 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.ExpandableListView._getAdapter10165 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.ExpandableListView._getExpandableListAdapter10166 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;");
			global::android.widget.ExpandableListView._getSelectedId10167 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getSelectedId", "()J");
			global::android.widget.ExpandableListView._getSelectedPosition10168 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getSelectedPosition", "()J");
			global::android.widget.ExpandableListView._setSelectedChild10169 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setSelectedChild", "(IIZ)Z");
			global::android.widget.ExpandableListView._setSelectedGroup10170 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setSelectedGroup", "(I)V");
			global::android.widget.ExpandableListView._setChildDivider10171 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setChildDivider", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._expandGroup10172 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "expandGroup", "(I)Z");
			global::android.widget.ExpandableListView._collapseGroup10173 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "collapseGroup", "(I)Z");
			global::android.widget.ExpandableListView._setOnGroupCollapseListener10174 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnGroupCollapseListener", "(Landroid/widget/ExpandableListView$OnGroupCollapseListener;)V");
			global::android.widget.ExpandableListView._setOnGroupExpandListener10175 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnGroupExpandListener", "(Landroid/widget/ExpandableListView$OnGroupExpandListener;)V");
			global::android.widget.ExpandableListView._setOnGroupClickListener10176 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnGroupClickListener", "(Landroid/widget/ExpandableListView$OnGroupClickListener;)V");
			global::android.widget.ExpandableListView._setOnChildClickListener10177 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnChildClickListener", "(Landroid/widget/ExpandableListView$OnChildClickListener;)V");
			global::android.widget.ExpandableListView._getExpandableListPosition10178 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getExpandableListPosition", "(I)J");
			global::android.widget.ExpandableListView._getFlatListPosition10179 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getFlatListPosition", "(J)I");
			global::android.widget.ExpandableListView._isGroupExpanded10180 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "isGroupExpanded", "(I)Z");
			global::android.widget.ExpandableListView._getPackedPositionType10181 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionType", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionGroup10182 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionGroup", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionChild10183 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionChild", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionForChild10184 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForChild", "(II)J");
			global::android.widget.ExpandableListView._getPackedPositionForGroup10185 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForGroup", "(I)J");
			global::android.widget.ExpandableListView._setChildIndicator10186 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setChildIndicator", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._setChildIndicatorBounds10187 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setChildIndicatorBounds", "(II)V");
			global::android.widget.ExpandableListView._setGroupIndicator10188 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setGroupIndicator", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._setIndicatorBounds10189 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setIndicatorBounds", "(II)V");
			global::android.widget.ExpandableListView._ExpandableListView10190 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ExpandableListView._ExpandableListView10191 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ExpandableListView._ExpandableListView10192 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
