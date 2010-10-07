namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class BaseAdapter : java.lang.Object, ListAdapter, SpinnerAdapter
	{
		internal static global::java.lang.Class staticClass;
		static BaseAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.BaseAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected BaseAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount10641;
		public abstract int getCount();
		internal static global::net.sf.jni4net.jni.MethodId _getItem10642;
		public abstract global::java.lang.Object getItem(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getItemId10643;
		public abstract long getItemId(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getView10644;
		public abstract global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2);
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty10645;
		public virtual bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.BaseAdapter._isEmpty10645);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._isEmpty10645);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled10646;
		public virtual bool isEnabled(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.BaseAdapter._isEnabled10646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._isEnabled10646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver10647;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.BaseAdapter._registerDataSetObserver10647, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._registerDataSetObserver10647, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver10648;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.BaseAdapter._unregisterDataSetObserver10648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._unregisterDataSetObserver10648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled10649;
		public virtual bool areAllItemsEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.BaseAdapter._areAllItemsEnabled10649);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._areAllItemsEnabled10649);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds10650;
		public virtual bool hasStableIds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.BaseAdapter._hasStableIds10650);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._hasStableIds10650);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType10651;
		public virtual int getItemViewType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.BaseAdapter._getItemViewType10651, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getItemViewType10651, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount10652;
		public virtual int getViewTypeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.BaseAdapter._getViewTypeCount10652);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getViewTypeCount10652);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView10653;
		public virtual global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.BaseAdapter._getDropDownView10653, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getDropDownView10653, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetChanged10654;
		public virtual void notifyDataSetChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.BaseAdapter._notifyDataSetChanged10654);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._notifyDataSetChanged10654);
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetInvalidated10655;
		public virtual void notifyDataSetInvalidated() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.BaseAdapter._notifyDataSetInvalidated10655);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._notifyDataSetInvalidated10655);
		}
		internal static global::net.sf.jni4net.jni.MethodId _BaseAdapter10656;
		public BaseAdapter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._BaseAdapter10656, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.BaseAdapter.staticClass = @__class;
			global::android.widget.BaseAdapter._getCount10641 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getCount", "()I");
			global::android.widget.BaseAdapter._getItem10642 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.BaseAdapter._getItemId10643 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.BaseAdapter._getView10644 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseAdapter._isEmpty10645 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "isEmpty", "()Z");
			global::android.widget.BaseAdapter._isEnabled10646 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "isEnabled", "(I)Z");
			global::android.widget.BaseAdapter._registerDataSetObserver10647 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseAdapter._unregisterDataSetObserver10648 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseAdapter._areAllItemsEnabled10649 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.BaseAdapter._hasStableIds10650 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.BaseAdapter._getItemViewType10651 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getItemViewType", "(I)I");
			global::android.widget.BaseAdapter._getViewTypeCount10652 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getViewTypeCount", "()I");
			global::android.widget.BaseAdapter._getDropDownView10653 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseAdapter._notifyDataSetChanged10654 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.BaseAdapter._notifyDataSetInvalidated10655 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "notifyDataSetInvalidated", "()V");
			global::android.widget.BaseAdapter._BaseAdapter10656 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "<init>", "()V");
		}
	}
}
