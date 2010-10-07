namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ExpandableListAdapter 
	{
		bool isEmpty();
		void registerDataSetObserver(android.database.DataSetObserver arg0);
		void unregisterDataSetObserver(android.database.DataSetObserver arg0);
		long getGroupId(int arg0);
		bool areAllItemsEnabled();
		bool hasStableIds();
		int getGroupCount();
		int getChildrenCount(int arg0);
		global::java.lang.Object getGroup(int arg0);
		global::java.lang.Object getChild(int arg0, int arg1);
		long getChildId(int arg0, int arg1);
		global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3);
		global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4);
		bool isChildSelectable(int arg0, int arg1);
		void onGroupExpanded(int arg0);
		void onGroupCollapsed(int arg0);
		long getCombinedChildId(long arg0, long arg1);
		long getCombinedGroupId(long arg0);
	}

	public partial class ExpandableListAdapter_
	{
		public static global::java.lang.Class _class
		{
			get { return __ExpandableListAdapter.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ExpandableListAdapter : java.lang.Object, ExpandableListAdapter
	{
		internal static global::java.lang.Class staticClass;
		static __ExpandableListAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.__ExpandableListAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.__ExpandableListAdapter(@__env);
			}
		}
		internal __ExpandableListAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty10834;
		 bool android.widget.ExpandableListAdapter.isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__ExpandableListAdapter._isEmpty10834);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._isEmpty10834);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver10835;
		 void android.widget.ExpandableListAdapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__ExpandableListAdapter._registerDataSetObserver10835, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._registerDataSetObserver10835, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver10836;
		 void android.widget.ExpandableListAdapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__ExpandableListAdapter._unregisterDataSetObserver10836, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._unregisterDataSetObserver10836, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroupId10837;
		 long android.widget.ExpandableListAdapter.getGroupId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.__ExpandableListAdapter._getGroupId10837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getGroupId10837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled10838;
		 bool android.widget.ExpandableListAdapter.areAllItemsEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__ExpandableListAdapter._areAllItemsEnabled10838);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._areAllItemsEnabled10838);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds10839;
		 bool android.widget.ExpandableListAdapter.hasStableIds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__ExpandableListAdapter._hasStableIds10839);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._hasStableIds10839);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroupCount10840;
		 int android.widget.ExpandableListAdapter.getGroupCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__ExpandableListAdapter._getGroupCount10840);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getGroupCount10840);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildrenCount10841;
		 int android.widget.ExpandableListAdapter.getChildrenCount(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__ExpandableListAdapter._getChildrenCount10841, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getChildrenCount10841, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroup10842;
		 global::java.lang.Object android.widget.ExpandableListAdapter.getGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter._getGroup10842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getGroup10842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChild10843;
		 global::java.lang.Object android.widget.ExpandableListAdapter.getChild(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter._getChild10843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getChild10843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildId10844;
		 long android.widget.ExpandableListAdapter.getChildId(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.__ExpandableListAdapter._getChildId10844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getChildId10844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroupView10845;
		 global::android.view.View android.widget.ExpandableListAdapter.getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter._getGroupView10845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getGroupView10845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildView10846;
		 global::android.view.View android.widget.ExpandableListAdapter.getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter._getChildView10846, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getChildView10846, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChildSelectable10847;
		 bool android.widget.ExpandableListAdapter.isChildSelectable(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__ExpandableListAdapter._isChildSelectable10847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._isChildSelectable10847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGroupExpanded10848;
		 void android.widget.ExpandableListAdapter.onGroupExpanded(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__ExpandableListAdapter._onGroupExpanded10848, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._onGroupExpanded10848, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGroupCollapsed10849;
		 void android.widget.ExpandableListAdapter.onGroupCollapsed(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__ExpandableListAdapter._onGroupCollapsed10849, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._onGroupCollapsed10849, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCombinedChildId10850;
		 long android.widget.ExpandableListAdapter.getCombinedChildId(long arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.__ExpandableListAdapter._getCombinedChildId10850, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getCombinedChildId10850, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCombinedGroupId10851;
		 long android.widget.ExpandableListAdapter.getCombinedGroupId(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.__ExpandableListAdapter._getCombinedGroupId10851, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getCombinedGroupId10851, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.__ExpandableListAdapter.staticClass = @__class;
			global::android.widget.__ExpandableListAdapter._isEmpty10834 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.isEmpty", "()Z");
			global::android.widget.__ExpandableListAdapter._registerDataSetObserver10835 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.__ExpandableListAdapter._unregisterDataSetObserver10836 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.__ExpandableListAdapter._getGroupId10837 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getGroupId", "(I)J");
			global::android.widget.__ExpandableListAdapter._areAllItemsEnabled10838 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.areAllItemsEnabled", "()Z");
			global::android.widget.__ExpandableListAdapter._hasStableIds10839 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.hasStableIds", "()Z");
			global::android.widget.__ExpandableListAdapter._getGroupCount10840 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getGroupCount", "()I");
			global::android.widget.__ExpandableListAdapter._getChildrenCount10841 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getChildrenCount", "(I)I");
			global::android.widget.__ExpandableListAdapter._getGroup10842 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.__ExpandableListAdapter._getChild10843 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getChild", "(II)Ljava/lang/Object;");
			global::android.widget.__ExpandableListAdapter._getChildId10844 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getChildId", "(II)J");
			global::android.widget.__ExpandableListAdapter._getGroupView10845 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.__ExpandableListAdapter._getChildView10846 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.__ExpandableListAdapter._isChildSelectable10847 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.isChildSelectable", "(II)Z");
			global::android.widget.__ExpandableListAdapter._onGroupExpanded10848 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.onGroupExpanded", "(I)V");
			global::android.widget.__ExpandableListAdapter._onGroupCollapsed10849 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.onGroupCollapsed", "(I)V");
			global::android.widget.__ExpandableListAdapter._getCombinedChildId10850 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getCombinedChildId", "(JJ)J");
			global::android.widget.__ExpandableListAdapter._getCombinedGroupId10851 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getCombinedGroupId", "(J)J");
		}
	}
}
