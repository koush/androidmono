namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ExpandableListView : android.widget.ListView
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ExpandableListView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ExpandableListView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ExpandableListView.ExpandableListContextMenuInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _ExpandableListContextMenuInfo9413; 
			public ExpandableListContextMenuInfo(android.view.View arg0, long arg1, long arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, _ExpandableListContextMenuInfo9413, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _targetView9414; 
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
			internal static global::net.sf.jni4net.jni.FieldId _packedPosition9415; 
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
			internal static global::net.sf.jni4net.jni.FieldId _id9416; 
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
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._ExpandableListContextMenuInfo9413 = @__env.GetMethodID(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;JJ)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnChildClickListener 
		{ 
			bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGroupClickListener 
		{ 
			bool onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGroupCollapseListener 
		{ 
			void onGroupCollapse(int arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGroupExpandListener 
		{ 
			void onGroupExpand(int arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState9417; 
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState9417, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _onRestoreInstanceState9417, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState9418; 
		public override android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState9418)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ExpandableListView.staticClass, _onSaveInstanceState9418)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw9419; 
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _dispatchDraw9419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _dispatchDraw9419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9420; 
		public override void setAdapter(android.widget.ListAdapter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setAdapter9420, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setAdapter9420, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9421; 
		public virtual void setAdapter(android.widget.ExpandableListAdapter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setAdapter9421, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setAdapter9421, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemClickListener9422; 
		public override void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setOnItemClickListener9422, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setOnItemClickListener9422, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performItemClick9423; 
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				return @__env.CallBooleanMethod(this, _performItemClick9423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ExpandableListView.staticClass, _performItemClick9423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter9424; 
		public virtual new android.widget.ListAdapter getAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, _getAdapter9424)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ExpandableListView.staticClass, _getAdapter9424)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExpandableListAdapter9425; 
		public virtual android.widget.ExpandableListAdapter getExpandableListAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ExpandableListAdapter>(@__env, @__env.CallObjectMethodPtr(this, _getExpandableListAdapter9425)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ExpandableListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ExpandableListView.staticClass, _getExpandableListAdapter9425)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedId9426; 
		public virtual long getSelectedId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				return @__env.CallLongMethod(this, _getSelectedId9426); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.ExpandableListView.staticClass, _getSelectedId9426); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedPosition9427; 
		public virtual long getSelectedPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				return @__env.CallLongMethod(this, _getSelectedPosition9427); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.ExpandableListView.staticClass, _getSelectedPosition9427); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelectedChild9428; 
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				return @__env.CallBooleanMethod(this, _setSelectedChild9428, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ExpandableListView.staticClass, _setSelectedChild9428, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelectedGroup9429; 
		public virtual void setSelectedGroup(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setSelectedGroup9429, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setSelectedGroup9429, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildDivider9430; 
		public virtual void setChildDivider(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setChildDivider9430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setChildDivider9430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _expandGroup9431; 
		public virtual bool expandGroup(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				return @__env.CallBooleanMethod(this, _expandGroup9431, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ExpandableListView.staticClass, _expandGroup9431, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _collapseGroup9432; 
		public virtual bool collapseGroup(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				return @__env.CallBooleanMethod(this, _collapseGroup9432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ExpandableListView.staticClass, _collapseGroup9432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnGroupCollapseListener9433; 
		public virtual void setOnGroupCollapseListener(android.widget.ExpandableListView.OnGroupCollapseListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setOnGroupCollapseListener9433, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setOnGroupCollapseListener9433, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnGroupExpandListener9434; 
		public virtual void setOnGroupExpandListener(android.widget.ExpandableListView.OnGroupExpandListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setOnGroupExpandListener9434, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setOnGroupExpandListener9434, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnGroupClickListener9435; 
		public virtual void setOnGroupClickListener(android.widget.ExpandableListView.OnGroupClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setOnGroupClickListener9435, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setOnGroupClickListener9435, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnChildClickListener9436; 
		public virtual void setOnChildClickListener(android.widget.ExpandableListView.OnChildClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setOnChildClickListener9436, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setOnChildClickListener9436, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExpandableListPosition9437; 
		public virtual long getExpandableListPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				return @__env.CallLongMethod(this, _getExpandableListPosition9437, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.ExpandableListView.staticClass, _getExpandableListPosition9437, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFlatListPosition9438; 
		public virtual int getFlatListPosition(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				return @__env.CallIntMethod(this, _getFlatListPosition9438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ExpandableListView.staticClass, _getFlatListPosition9438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isGroupExpanded9439; 
		public virtual bool isGroupExpanded(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				return @__env.CallBooleanMethod(this, _isGroupExpanded9439, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ExpandableListView.staticClass, _isGroupExpanded9439, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionType9440; 
		public static int getPackedPositionType(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, _getPackedPositionType9440, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionGroup9441; 
		public static int getPackedPositionGroup(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, _getPackedPositionGroup9441, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionChild9442; 
		public static int getPackedPositionChild(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, _getPackedPositionChild9442, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionForChild9443; 
		public static long getPackedPositionForChild(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, _getPackedPositionForChild9443, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionForGroup9444; 
		public static long getPackedPositionForGroup(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, _getPackedPositionForGroup9444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildIndicator9445; 
		public virtual void setChildIndicator(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setChildIndicator9445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setChildIndicator9445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildIndicatorBounds9446; 
		public virtual void setChildIndicatorBounds(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setChildIndicatorBounds9446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setChildIndicatorBounds9446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGroupIndicator9447; 
		public virtual void setGroupIndicator(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setGroupIndicator9447, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setGroupIndicator9447, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIndicatorBounds9448; 
		public virtual void setIndicatorBounds(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ExpandableListView)) 
				@__env.CallVoidMethod(this, _setIndicatorBounds9448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ExpandableListView.staticClass, _setIndicatorBounds9448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExpandableListView9449; 
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ExpandableListView.staticClass, _ExpandableListView9449, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExpandableListView9450; 
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ExpandableListView.staticClass, _ExpandableListView9450, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExpandableListView9451; 
		public ExpandableListView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ExpandableListView.staticClass, _ExpandableListView9451, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			global::android.widget.ExpandableListView._onRestoreInstanceState9417 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.widget.ExpandableListView._onSaveInstanceState9418 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.widget.ExpandableListView._dispatchDraw9419 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.ExpandableListView._setAdapter9420 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V"); 
			global::android.widget.ExpandableListView._setAdapter9421 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ExpandableListAdapter;)V"); 
			global::android.widget.ExpandableListView._setOnItemClickListener9422 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V"); 
			global::android.widget.ExpandableListView._performItemClick9423 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z"); 
			global::android.widget.ExpandableListView._getAdapter9424 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;"); 
			global::android.widget.ExpandableListView._getExpandableListAdapter9425 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;"); 
			global::android.widget.ExpandableListView._getSelectedId9426 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getSelectedId", "()J"); 
			global::android.widget.ExpandableListView._getSelectedPosition9427 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getSelectedPosition", "()J"); 
			global::android.widget.ExpandableListView._setSelectedChild9428 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setSelectedChild", "(IIZ)Z"); 
			global::android.widget.ExpandableListView._setSelectedGroup9429 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setSelectedGroup", "(I)V"); 
			global::android.widget.ExpandableListView._setChildDivider9430 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setChildDivider", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ExpandableListView._expandGroup9431 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "expandGroup", "(I)Z"); 
			global::android.widget.ExpandableListView._collapseGroup9432 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "collapseGroup", "(I)Z"); 
			global::android.widget.ExpandableListView._setOnGroupCollapseListener9433 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnGroupCollapseListener", "(Landroid/widget/ExpandableListView$OnGroupCollapseListener;)V"); 
			global::android.widget.ExpandableListView._setOnGroupExpandListener9434 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnGroupExpandListener", "(Landroid/widget/ExpandableListView$OnGroupExpandListener;)V"); 
			global::android.widget.ExpandableListView._setOnGroupClickListener9435 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnGroupClickListener", "(Landroid/widget/ExpandableListView$OnGroupClickListener;)V"); 
			global::android.widget.ExpandableListView._setOnChildClickListener9436 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnChildClickListener", "(Landroid/widget/ExpandableListView$OnChildClickListener;)V"); 
			global::android.widget.ExpandableListView._getExpandableListPosition9437 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getExpandableListPosition", "(I)J"); 
			global::android.widget.ExpandableListView._getFlatListPosition9438 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getFlatListPosition", "(J)I"); 
			global::android.widget.ExpandableListView._isGroupExpanded9439 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "isGroupExpanded", "(I)Z"); 
			global::android.widget.ExpandableListView._getPackedPositionType9440 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionType", "(J)I"); 
			global::android.widget.ExpandableListView._getPackedPositionGroup9441 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionGroup", "(J)I"); 
			global::android.widget.ExpandableListView._getPackedPositionChild9442 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionChild", "(J)I"); 
			global::android.widget.ExpandableListView._getPackedPositionForChild9443 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForChild", "(II)J"); 
			global::android.widget.ExpandableListView._getPackedPositionForGroup9444 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForGroup", "(I)J"); 
			global::android.widget.ExpandableListView._setChildIndicator9445 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setChildIndicator", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ExpandableListView._setChildIndicatorBounds9446 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setChildIndicatorBounds", "(II)V"); 
			global::android.widget.ExpandableListView._setGroupIndicator9447 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setGroupIndicator", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ExpandableListView._setIndicatorBounds9448 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setIndicatorBounds", "(II)V"); 
			global::android.widget.ExpandableListView._ExpandableListView9449 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.ExpandableListView._ExpandableListView9450 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.ExpandableListView._ExpandableListView9451 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
