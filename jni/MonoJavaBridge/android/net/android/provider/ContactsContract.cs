namespace android.provider 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class ContactsContract : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ContactsContract() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.provider.ContactsContract(@__env); 
			} 
		} 
		internal ContactsContract(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class AggregationExceptions : java.lang.Object, BaseColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static AggregationExceptions() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.AggregationExceptions), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.AggregationExceptions(@__env); 
				} 
			} 
			internal AggregationExceptions(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6192; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String CONTENT_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/aggregation_exception"; 
				} 
			} 
			public static java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/aggregation_exception"; 
				} 
			} 
			public static java.lang.String TYPE
			{ 
				get 
				{ 
					return "type"; 
				} 
			} 
			public static int TYPE_AUTOMATIC
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int TYPE_KEEP_TOGETHER
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int TYPE_KEEP_SEPARATE
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
			public static java.lang.String RAW_CONTACT_ID1
			{ 
				get 
				{ 
					return "raw_contact_id1"; 
				} 
			} 
			public static java.lang.String RAW_CONTACT_ID2
			{ 
				get 
				{ 
					return "raw_contact_id2"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.AggregationExceptions.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface BaseSyncColumns 
		{ 
		} 

		public partial class BaseSyncColumns_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __BaseSyncColumns.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __BaseSyncColumns : java.lang.Object, BaseSyncColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static __BaseSyncColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__BaseSyncColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__BaseSyncColumns(@__env); 
				} 
			} 
			internal __BaseSyncColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__BaseSyncColumns.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class BaseSyncColumnsConstants 
		{ 
			public static java.lang.String SYNC1
			{ 
				get 
				{ 
					return "sync1"; 
				} 
			} 
			public static java.lang.String SYNC2
			{ 
				get 
				{ 
					return "sync2"; 
				} 
			} 
			public static java.lang.String SYNC3
			{ 
				get 
				{ 
					return "sync3"; 
				} 
			} 
			public static java.lang.String SYNC4
			{ 
				get 
				{ 
					return "sync4"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class CommonDataKinds : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static CommonDataKinds() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.CommonDataKinds(@__env); 
				} 
			} 
			internal CommonDataKinds(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
			public interface BaseTypes 
			{ 
			} 

			public partial class BaseTypes_ 
			{ 
				public static global::java.lang.Class _class 
				{ 
					get { return __BaseTypes.staticClass; } 
				} 
			} 

			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class __BaseTypes : java.lang.Object, BaseTypes
			{ 
				internal static global::java.lang.Class staticClass; 
				static __BaseTypes() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.__BaseTypes), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.__BaseTypes(@__env); 
					} 
				} 
				internal __BaseTypes(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.__BaseTypes.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public static class BaseTypesConstants 
			{ 
				public static int TYPE_CUSTOM
				{ 
					get 
					{ 
						return 0; 
					} 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
			protected interface CommonColumns : BaseTypes
			{ 
			} 

			public partial class CommonColumns_ 
			{ 
				public static global::java.lang.Class _class 
				{ 
					get { return __CommonColumns.staticClass; } 
				} 
			} 

			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			protected sealed class __CommonColumns : java.lang.Object, CommonColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static __CommonColumns() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.__CommonColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.__CommonColumns(@__env); 
					} 
				} 
				internal __CommonColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.__CommonColumns.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public static class CommonColumnsConstants 
			{ 
				public static java.lang.String DATA
				{ 
					get 
					{ 
						return "data1"; 
					} 
				} 
				public static java.lang.String TYPE
				{ 
					get 
					{ 
						return "data2"; 
					} 
				} 
				public static java.lang.String LABEL
				{ 
					get 
					{ 
						return "data3"; 
					} 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Email : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Email() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.Email), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.Email(@__env); 
					} 
				} 
				internal Email(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getTypeLabelResource6193; 
				public static int getTypeLabelResource(int arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.Email.staticClass, _getTypeLabelResource6193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getTypeLabel6194; 
				public static java.lang.CharSequence getTypeLabel(android.content.res.Resources arg0, int arg1, java.lang.CharSequence arg2) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.CommonDataKinds.Email.staticClass, _getTypeLabel6194, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/email_v2"; 
					} 
				} 
				public static java.lang.String CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.dir/email_v2"; 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6195; 
				public static android.net.Uri CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _CONTENT_LOOKUP_URI6196; 
				public static android.net.Uri CONTENT_LOOKUP_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _CONTENT_FILTER_URI6197; 
				public static android.net.Uri CONTENT_FILTER_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				public static int TYPE_HOME
				{ 
					get 
					{ 
						return 1; 
					} 
				} 
				public static int TYPE_WORK
				{ 
					get 
					{ 
						return 2; 
					} 
				} 
				public static int TYPE_OTHER
				{ 
					get 
					{ 
						return 3; 
					} 
				} 
				public static int TYPE_MOBILE
				{ 
					get 
					{ 
						return 4; 
					} 
				} 
				public static java.lang.String DISPLAY_NAME
				{ 
					get 
					{ 
						return "data4"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.Email.staticClass = @__class; 
					global::android.provider.ContactsContract.CommonDataKinds.Email._getTypeLabelResource6193 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.Email.staticClass, "getTypeLabelResource", "(I)I"); 
					global::android.provider.ContactsContract.CommonDataKinds.Email._getTypeLabel6194 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.Email.staticClass, "getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Event : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Event() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.Event), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.Event(@__env); 
					} 
				} 
				internal Event(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getTypeResource6198; 
				public static int getTypeResource(java.lang.Integer arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.Event.staticClass, _getTypeResource6198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/contact_event"; 
					} 
				} 
				public static int TYPE_ANNIVERSARY
				{ 
					get 
					{ 
						return 1; 
					} 
				} 
				public static int TYPE_OTHER
				{ 
					get 
					{ 
						return 2; 
					} 
				} 
				public static int TYPE_BIRTHDAY
				{ 
					get 
					{ 
						return 3; 
					} 
				} 
				public static java.lang.String START_DATE
				{ 
					get 
					{ 
						return "data1"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.Event.staticClass = @__class; 
					global::android.provider.ContactsContract.CommonDataKinds.Event._getTypeResource6198 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.Event.staticClass, "getTypeResource", "(Ljava/lang/Integer;)I"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class GroupMembership : java.lang.Object, DataColumnsWithJoins
			{ 
				internal static global::java.lang.Class staticClass; 
				static GroupMembership() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.GroupMembership), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.GroupMembership(@__env); 
					} 
				} 
				internal GroupMembership(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/group_membership"; 
					} 
				} 
				public static java.lang.String GROUP_ROW_ID
				{ 
					get 
					{ 
						return "data1"; 
					} 
				} 
				public static java.lang.String GROUP_SOURCE_ID
				{ 
					get 
					{ 
						return "group_sourceid"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.GroupMembership.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Im : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Im() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.Im), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.Im(@__env); 
					} 
				} 
				internal Im(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getTypeLabelResource6199; 
				public static int getTypeLabelResource(int arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.Im.staticClass, _getTypeLabelResource6199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getTypeLabel6200; 
				public static java.lang.CharSequence getTypeLabel(android.content.res.Resources arg0, int arg1, java.lang.CharSequence arg2) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.CommonDataKinds.Im.staticClass, _getTypeLabel6200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getProtocolLabelResource6201; 
				public static int getProtocolLabelResource(int arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.Im.staticClass, _getProtocolLabelResource6201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getProtocolLabel6202; 
				public static java.lang.CharSequence getProtocolLabel(android.content.res.Resources arg0, int arg1, java.lang.CharSequence arg2) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.CommonDataKinds.Im.staticClass, _getProtocolLabel6202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/im"; 
					} 
				} 
				public static int TYPE_HOME
				{ 
					get 
					{ 
						return 1; 
					} 
				} 
				public static int TYPE_WORK
				{ 
					get 
					{ 
						return 2; 
					} 
				} 
				public static int TYPE_OTHER
				{ 
					get 
					{ 
						return 3; 
					} 
				} 
				public static java.lang.String PROTOCOL
				{ 
					get 
					{ 
						return "data5"; 
					} 
				} 
				public static java.lang.String CUSTOM_PROTOCOL
				{ 
					get 
					{ 
						return "data6"; 
					} 
				} 
				public static int PROTOCOL_CUSTOM
				{ 
					get 
					{ 
						return -1; 
					} 
				} 
				public static int PROTOCOL_AIM
				{ 
					get 
					{ 
						return 0; 
					} 
				} 
				public static int PROTOCOL_MSN
				{ 
					get 
					{ 
						return 1; 
					} 
				} 
				public static int PROTOCOL_YAHOO
				{ 
					get 
					{ 
						return 2; 
					} 
				} 
				public static int PROTOCOL_SKYPE
				{ 
					get 
					{ 
						return 3; 
					} 
				} 
				public static int PROTOCOL_QQ
				{ 
					get 
					{ 
						return 4; 
					} 
				} 
				public static int PROTOCOL_GOOGLE_TALK
				{ 
					get 
					{ 
						return 5; 
					} 
				} 
				public static int PROTOCOL_ICQ
				{ 
					get 
					{ 
						return 6; 
					} 
				} 
				public static int PROTOCOL_JABBER
				{ 
					get 
					{ 
						return 7; 
					} 
				} 
				public static int PROTOCOL_NETMEETING
				{ 
					get 
					{ 
						return 8; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.Im.staticClass = @__class; 
					global::android.provider.ContactsContract.CommonDataKinds.Im._getTypeLabelResource6199 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.Im.staticClass, "getTypeLabelResource", "(I)I"); 
					global::android.provider.ContactsContract.CommonDataKinds.Im._getTypeLabel6200 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.Im.staticClass, "getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
					global::android.provider.ContactsContract.CommonDataKinds.Im._getProtocolLabelResource6201 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.Im.staticClass, "getProtocolLabelResource", "(I)I"); 
					global::android.provider.ContactsContract.CommonDataKinds.Im._getProtocolLabel6202 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.Im.staticClass, "getProtocolLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Nickname : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Nickname() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.Nickname), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.Nickname(@__env); 
					} 
				} 
				internal Nickname(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/nickname"; 
					} 
				} 
				public static int TYPE_DEFAULT
				{ 
					get 
					{ 
						return 1; 
					} 
				} 
				public static int TYPE_OTHER_NAME
				{ 
					get 
					{ 
						return 2; 
					} 
				} 
				public static int TYPE_MAINDEN_NAME
				{ 
					get 
					{ 
						return 3; 
					} 
				} 
				public static int TYPE_SHORT_NAME
				{ 
					get 
					{ 
						return 4; 
					} 
				} 
				public static int TYPE_INITIALS
				{ 
					get 
					{ 
						return 5; 
					} 
				} 
				public static java.lang.String NAME
				{ 
					get 
					{ 
						return "data1"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.Nickname.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Note : java.lang.Object, DataColumnsWithJoins
			{ 
				internal static global::java.lang.Class staticClass; 
				static Note() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.Note), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.Note(@__env); 
					} 
				} 
				internal Note(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/note"; 
					} 
				} 
				public static java.lang.String NOTE
				{ 
					get 
					{ 
						return "data1"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.Note.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Organization : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Organization() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.Organization), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.Organization(@__env); 
					} 
				} 
				internal Organization(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getTypeLabelResource6203; 
				public static int getTypeLabelResource(int arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.Organization.staticClass, _getTypeLabelResource6203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getTypeLabel6204; 
				public static java.lang.CharSequence getTypeLabel(android.content.res.Resources arg0, int arg1, java.lang.CharSequence arg2) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.CommonDataKinds.Organization.staticClass, _getTypeLabel6204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/organization"; 
					} 
				} 
				public static int TYPE_WORK
				{ 
					get 
					{ 
						return 1; 
					} 
				} 
				public static int TYPE_OTHER
				{ 
					get 
					{ 
						return 2; 
					} 
				} 
				public static java.lang.String COMPANY
				{ 
					get 
					{ 
						return "data1"; 
					} 
				} 
				public static java.lang.String TITLE
				{ 
					get 
					{ 
						return "data4"; 
					} 
				} 
				public static java.lang.String DEPARTMENT
				{ 
					get 
					{ 
						return "data5"; 
					} 
				} 
				public static java.lang.String JOB_DESCRIPTION
				{ 
					get 
					{ 
						return "data6"; 
					} 
				} 
				public static java.lang.String SYMBOL
				{ 
					get 
					{ 
						return "data7"; 
					} 
				} 
				public static java.lang.String PHONETIC_NAME
				{ 
					get 
					{ 
						return "data8"; 
					} 
				} 
				public static java.lang.String OFFICE_LOCATION
				{ 
					get 
					{ 
						return "data9"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.Organization.staticClass = @__class; 
					global::android.provider.ContactsContract.CommonDataKinds.Organization._getTypeLabelResource6203 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.Organization.staticClass, "getTypeLabelResource", "(I)I"); 
					global::android.provider.ContactsContract.CommonDataKinds.Organization._getTypeLabel6204 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.Organization.staticClass, "getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Phone : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Phone() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.Phone), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.Phone(@__env); 
					} 
				} 
				internal Phone(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getTypeLabelResource6205; 
				public static int getTypeLabelResource(int arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.Phone.staticClass, _getTypeLabelResource6205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getTypeLabel6206; 
				public static java.lang.CharSequence getTypeLabel(android.content.res.Resources arg0, int arg1, java.lang.CharSequence arg2) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.CommonDataKinds.Phone.staticClass, _getTypeLabel6206, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/phone_v2"; 
					} 
				} 
				public static java.lang.String CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.dir/phone_v2"; 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6207; 
				public static android.net.Uri CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _CONTENT_FILTER_URI6208; 
				public static android.net.Uri CONTENT_FILTER_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				public static int TYPE_HOME
				{ 
					get 
					{ 
						return 1; 
					} 
				} 
				public static int TYPE_MOBILE
				{ 
					get 
					{ 
						return 2; 
					} 
				} 
				public static int TYPE_WORK
				{ 
					get 
					{ 
						return 3; 
					} 
				} 
				public static int TYPE_FAX_WORK
				{ 
					get 
					{ 
						return 4; 
					} 
				} 
				public static int TYPE_FAX_HOME
				{ 
					get 
					{ 
						return 5; 
					} 
				} 
				public static int TYPE_PAGER
				{ 
					get 
					{ 
						return 6; 
					} 
				} 
				public static int TYPE_OTHER
				{ 
					get 
					{ 
						return 7; 
					} 
				} 
				public static int TYPE_CALLBACK
				{ 
					get 
					{ 
						return 8; 
					} 
				} 
				public static int TYPE_CAR
				{ 
					get 
					{ 
						return 9; 
					} 
				} 
				public static int TYPE_COMPANY_MAIN
				{ 
					get 
					{ 
						return 10; 
					} 
				} 
				public static int TYPE_ISDN
				{ 
					get 
					{ 
						return 11; 
					} 
				} 
				public static int TYPE_MAIN
				{ 
					get 
					{ 
						return 12; 
					} 
				} 
				public static int TYPE_OTHER_FAX
				{ 
					get 
					{ 
						return 13; 
					} 
				} 
				public static int TYPE_RADIO
				{ 
					get 
					{ 
						return 14; 
					} 
				} 
				public static int TYPE_TELEX
				{ 
					get 
					{ 
						return 15; 
					} 
				} 
				public static int TYPE_TTY_TDD
				{ 
					get 
					{ 
						return 16; 
					} 
				} 
				public static int TYPE_WORK_MOBILE
				{ 
					get 
					{ 
						return 17; 
					} 
				} 
				public static int TYPE_WORK_PAGER
				{ 
					get 
					{ 
						return 18; 
					} 
				} 
				public static int TYPE_ASSISTANT
				{ 
					get 
					{ 
						return 19; 
					} 
				} 
				public static int TYPE_MMS
				{ 
					get 
					{ 
						return 20; 
					} 
				} 
				public static java.lang.String NUMBER
				{ 
					get 
					{ 
						return "data1"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.Phone.staticClass = @__class; 
					global::android.provider.ContactsContract.CommonDataKinds.Phone._getTypeLabelResource6205 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.Phone.staticClass, "getTypeLabelResource", "(I)I"); 
					global::android.provider.ContactsContract.CommonDataKinds.Phone._getTypeLabel6206 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.Phone.staticClass, "getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Photo : java.lang.Object, DataColumnsWithJoins
			{ 
				internal static global::java.lang.Class staticClass; 
				static Photo() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.Photo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.Photo(@__env); 
					} 
				} 
				internal Photo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/photo"; 
					} 
				} 
				public static java.lang.String PHOTO
				{ 
					get 
					{ 
						return "data15"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.Photo.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Relation : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Relation() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.Relation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.Relation(@__env); 
					} 
				} 
				internal Relation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/relation"; 
					} 
				} 
				public static int TYPE_ASSISTANT
				{ 
					get 
					{ 
						return 1; 
					} 
				} 
				public static int TYPE_BROTHER
				{ 
					get 
					{ 
						return 2; 
					} 
				} 
				public static int TYPE_CHILD
				{ 
					get 
					{ 
						return 3; 
					} 
				} 
				public static int TYPE_DOMESTIC_PARTNER
				{ 
					get 
					{ 
						return 4; 
					} 
				} 
				public static int TYPE_FATHER
				{ 
					get 
					{ 
						return 5; 
					} 
				} 
				public static int TYPE_FRIEND
				{ 
					get 
					{ 
						return 6; 
					} 
				} 
				public static int TYPE_MANAGER
				{ 
					get 
					{ 
						return 7; 
					} 
				} 
				public static int TYPE_MOTHER
				{ 
					get 
					{ 
						return 8; 
					} 
				} 
				public static int TYPE_PARENT
				{ 
					get 
					{ 
						return 9; 
					} 
				} 
				public static int TYPE_PARTNER
				{ 
					get 
					{ 
						return 10; 
					} 
				} 
				public static int TYPE_REFERRED_BY
				{ 
					get 
					{ 
						return 11; 
					} 
				} 
				public static int TYPE_RELATIVE
				{ 
					get 
					{ 
						return 12; 
					} 
				} 
				public static int TYPE_SISTER
				{ 
					get 
					{ 
						return 13; 
					} 
				} 
				public static int TYPE_SPOUSE
				{ 
					get 
					{ 
						return 14; 
					} 
				} 
				public static java.lang.String NAME
				{ 
					get 
					{ 
						return "data1"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.Relation.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class StructuredName : java.lang.Object, DataColumnsWithJoins
			{ 
				internal static global::java.lang.Class staticClass; 
				static StructuredName() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.StructuredName), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.StructuredName(@__env); 
					} 
				} 
				internal StructuredName(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/name"; 
					} 
				} 
				public static java.lang.String DISPLAY_NAME
				{ 
					get 
					{ 
						return "data1"; 
					} 
				} 
				public static java.lang.String GIVEN_NAME
				{ 
					get 
					{ 
						return "data2"; 
					} 
				} 
				public static java.lang.String FAMILY_NAME
				{ 
					get 
					{ 
						return "data3"; 
					} 
				} 
				public static java.lang.String PREFIX
				{ 
					get 
					{ 
						return "data4"; 
					} 
				} 
				public static java.lang.String MIDDLE_NAME
				{ 
					get 
					{ 
						return "data5"; 
					} 
				} 
				public static java.lang.String SUFFIX
				{ 
					get 
					{ 
						return "data6"; 
					} 
				} 
				public static java.lang.String PHONETIC_GIVEN_NAME
				{ 
					get 
					{ 
						return "data7"; 
					} 
				} 
				public static java.lang.String PHONETIC_MIDDLE_NAME
				{ 
					get 
					{ 
						return "data8"; 
					} 
				} 
				public static java.lang.String PHONETIC_FAMILY_NAME
				{ 
					get 
					{ 
						return "data9"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.StructuredName.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class StructuredPostal : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static StructuredPostal() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.StructuredPostal), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal(@__env); 
					} 
				} 
				internal StructuredPostal(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getTypeLabelResource6209; 
				public static int getTypeLabelResource(int arg0) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return @__env.CallStaticIntMethod(android.provider.ContactsContract.CommonDataKinds.StructuredPostal.staticClass, _getTypeLabelResource6209, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _getTypeLabel6210; 
				public static java.lang.CharSequence getTypeLabel(android.content.res.Resources arg0, int arg1, java.lang.CharSequence arg2) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.CommonDataKinds.StructuredPostal.staticClass, _getTypeLabel6210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/postal-address_v2"; 
					} 
				} 
				public static java.lang.String CONTENT_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.dir/postal-address_v2"; 
					} 
				} 
				internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6211; 
				public static android.net.Uri CONTENT_URI
				{ 
					get 
					{ 
						return default(android.net.Uri); 
					} 
				} 
				public static int TYPE_HOME
				{ 
					get 
					{ 
						return 1; 
					} 
				} 
				public static int TYPE_WORK
				{ 
					get 
					{ 
						return 2; 
					} 
				} 
				public static int TYPE_OTHER
				{ 
					get 
					{ 
						return 3; 
					} 
				} 
				public static java.lang.String FORMATTED_ADDRESS
				{ 
					get 
					{ 
						return "data1"; 
					} 
				} 
				public static java.lang.String STREET
				{ 
					get 
					{ 
						return "data4"; 
					} 
				} 
				public static java.lang.String POBOX
				{ 
					get 
					{ 
						return "data5"; 
					} 
				} 
				public static java.lang.String NEIGHBORHOOD
				{ 
					get 
					{ 
						return "data6"; 
					} 
				} 
				public static java.lang.String CITY
				{ 
					get 
					{ 
						return "data7"; 
					} 
				} 
				public static java.lang.String REGION
				{ 
					get 
					{ 
						return "data8"; 
					} 
				} 
				public static java.lang.String POSTCODE
				{ 
					get 
					{ 
						return "data9"; 
					} 
				} 
				public static java.lang.String COUNTRY
				{ 
					get 
					{ 
						return "data10"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal.staticClass = @__class; 
					global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal._getTypeLabelResource6209 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal.staticClass, "getTypeLabelResource", "(I)I"); 
					global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal._getTypeLabel6210 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.CommonDataKinds.StructuredPostal.staticClass, "getTypeLabel", "(Landroid/content/res/Resources;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Website : java.lang.Object, DataColumnsWithJoins, CommonColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Website() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.CommonDataKinds.Website), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.CommonDataKinds.Website(@__env); 
					} 
				} 
				internal Website(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_ITEM_TYPE
				{ 
					get 
					{ 
						return "vnd.android.cursor.item/website"; 
					} 
				} 
				public static int TYPE_HOMEPAGE
				{ 
					get 
					{ 
						return 1; 
					} 
				} 
				public static int TYPE_BLOG
				{ 
					get 
					{ 
						return 2; 
					} 
				} 
				public static int TYPE_PROFILE
				{ 
					get 
					{ 
						return 3; 
					} 
				} 
				public static int TYPE_HOME
				{ 
					get 
					{ 
						return 4; 
					} 
				} 
				public static int TYPE_WORK
				{ 
					get 
					{ 
						return 5; 
					} 
				} 
				public static int TYPE_FTP
				{ 
					get 
					{ 
						return 6; 
					} 
				} 
				public static int TYPE_OTHER
				{ 
					get 
					{ 
						return 7; 
					} 
				} 
				public static java.lang.String URL
				{ 
					get 
					{ 
						return "data1"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.CommonDataKinds.Website.staticClass = @__class; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.CommonDataKinds.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface ContactOptionsColumns 
		{ 
		} 

		public partial class ContactOptionsColumns_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __ContactOptionsColumns.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __ContactOptionsColumns : java.lang.Object, ContactOptionsColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static __ContactOptionsColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__ContactOptionsColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__ContactOptionsColumns(@__env); 
				} 
			} 
			internal __ContactOptionsColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__ContactOptionsColumns.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class ContactOptionsColumnsConstants 
		{ 
			public static java.lang.String TIMES_CONTACTED
			{ 
				get 
				{ 
					return "times_contacted"; 
				} 
			} 
			public static java.lang.String LAST_TIME_CONTACTED
			{ 
				get 
				{ 
					return "last_time_contacted"; 
				} 
			} 
			public static java.lang.String STARRED
			{ 
				get 
				{ 
					return "starred"; 
				} 
			} 
			public static java.lang.String CUSTOM_RINGTONE
			{ 
				get 
				{ 
					return "custom_ringtone"; 
				} 
			} 
			public static java.lang.String SEND_TO_VOICEMAIL
			{ 
				get 
				{ 
					return "send_to_voicemail"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface ContactStatusColumns 
		{ 
		} 

		public partial class ContactStatusColumns_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __ContactStatusColumns.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __ContactStatusColumns : java.lang.Object, ContactStatusColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static __ContactStatusColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__ContactStatusColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__ContactStatusColumns(@__env); 
				} 
			} 
			internal __ContactStatusColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__ContactStatusColumns.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class ContactStatusColumnsConstants 
		{ 
			public static java.lang.String CONTACT_PRESENCE
			{ 
				get 
				{ 
					return "contact_presence"; 
				} 
			} 
			public static java.lang.String CONTACT_STATUS
			{ 
				get 
				{ 
					return "contact_status"; 
				} 
			} 
			public static java.lang.String CONTACT_STATUS_TIMESTAMP
			{ 
				get 
				{ 
					return "contact_status_ts"; 
				} 
			} 
			public static java.lang.String CONTACT_STATUS_RES_PACKAGE
			{ 
				get 
				{ 
					return "contact_status_res_package"; 
				} 
			} 
			public static java.lang.String CONTACT_STATUS_LABEL
			{ 
				get 
				{ 
					return "contact_status_label"; 
				} 
			} 
			public static java.lang.String CONTACT_STATUS_ICON
			{ 
				get 
				{ 
					return "contact_status_icon"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Contacts : java.lang.Object, BaseColumns, ContactsColumns, ContactOptionsColumns, ContactStatusColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static Contacts() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.Contacts), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.Contacts(@__env); 
				} 
			} 
			protected Contacts(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class AggregationSuggestions : java.lang.Object, BaseColumns, ContactsColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static AggregationSuggestions() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.Contacts.AggregationSuggestions), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.Contacts.AggregationSuggestions(@__env); 
					} 
				} 
				internal AggregationSuggestions(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_DIRECTORY
				{ 
					get 
					{ 
						return "suggestions"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.Contacts.AggregationSuggestions.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Data : java.lang.Object, BaseColumns, DataColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Data() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.Contacts.Data), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.Contacts.Data(@__env); 
					} 
				} 
				internal Data(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_DIRECTORY
				{ 
					get 
					{ 
						return "data"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.Contacts.Data.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Photo : java.lang.Object, BaseColumns, DataColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Photo() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.Contacts.Photo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.Contacts.Photo(@__env); 
					} 
				} 
				internal Photo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_DIRECTORY
				{ 
					get 
					{ 
						return "photo"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.Contacts.Photo.staticClass = @__class; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _markAsContacted6212; 
			public static void markAsContacted(android.content.ContentResolver arg0, long arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.ContactsContract.Contacts.staticClass, _markAsContacted6212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _openContactPhotoInputStream6213; 
			public static java.io.InputStream openContactPhotoInputStream(android.content.ContentResolver arg0, android.net.Uri arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.Contacts.staticClass, _openContactPhotoInputStream6213, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLookupUri6214; 
			public static android.net.Uri getLookupUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.Contacts.staticClass, _getLookupUri6214, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLookupUri6215; 
			public static android.net.Uri getLookupUri(long arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.Contacts.staticClass, _getLookupUri6215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _lookupContact6216; 
			public static android.net.Uri lookupContact(android.content.ContentResolver arg0, android.net.Uri arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.Contacts.staticClass, _lookupContact6216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6217; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_LOOKUP_URI6218; 
			public static android.net.Uri CONTENT_LOOKUP_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_VCARD_URI6219; 
			public static android.net.Uri CONTENT_VCARD_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_FILTER_URI6220; 
			public static android.net.Uri CONTENT_FILTER_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_STREQUENT_URI6221; 
			public static android.net.Uri CONTENT_STREQUENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_STREQUENT_FILTER_URI6222; 
			public static android.net.Uri CONTENT_STREQUENT_FILTER_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_GROUP_URI6223; 
			public static android.net.Uri CONTENT_GROUP_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String CONTENT_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/contact"; 
				} 
			} 
			public static java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/contact"; 
				} 
			} 
			public static java.lang.String CONTENT_VCARD_TYPE
			{ 
				get 
				{ 
					return "text/x-vcard"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.Contacts.staticClass = @__class; 
				global::android.provider.ContactsContract.Contacts._markAsContacted6212 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.Contacts.staticClass, "markAsContacted", "(Landroid/content/ContentResolver;J)V"); 
				global::android.provider.ContactsContract.Contacts._openContactPhotoInputStream6213 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.Contacts.staticClass, "openContactPhotoInputStream", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Ljava/io/InputStream;"); 
				global::android.provider.ContactsContract.Contacts._getLookupUri6214 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.Contacts.staticClass, "getLookupUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;"); 
				global::android.provider.ContactsContract.Contacts._getLookupUri6215 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.Contacts.staticClass, "getLookupUri", "(JLjava/lang/String;)Landroid/net/Uri;"); 
				global::android.provider.ContactsContract.Contacts._lookupContact6216 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.Contacts.staticClass, "lookupContact", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface ContactsColumns 
		{ 
		} 

		public partial class ContactsColumns_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __ContactsColumns.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __ContactsColumns : java.lang.Object, ContactsColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static __ContactsColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__ContactsColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__ContactsColumns(@__env); 
				} 
			} 
			internal __ContactsColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__ContactsColumns.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class ContactsColumnsConstants 
		{ 
			public static java.lang.String DISPLAY_NAME
			{ 
				get 
				{ 
					return "display_name"; 
				} 
			} 
			public static java.lang.String PHOTO_ID
			{ 
				get 
				{ 
					return "photo_id"; 
				} 
			} 
			public static java.lang.String IN_VISIBLE_GROUP
			{ 
				get 
				{ 
					return "in_visible_group"; 
				} 
			} 
			public static java.lang.String HAS_PHONE_NUMBER
			{ 
				get 
				{ 
					return "has_phone_number"; 
				} 
			} 
			public static java.lang.String LOOKUP_KEY
			{ 
				get 
				{ 
					return "lookup"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Data : java.lang.Object, DataColumnsWithJoins
		{ 
			internal static global::java.lang.Class staticClass; 
			static Data() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.Data), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.Data(@__env); 
				} 
			} 
			internal Data(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getContactLookupUri6224; 
			public static android.net.Uri getContactLookupUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.Data.staticClass, _getContactLookupUri6224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6225; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String CONTENT_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/data"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.Data.staticClass = @__class; 
				global::android.provider.ContactsContract.Data._getContactLookupUri6224 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.Data.staticClass, "getContactLookupUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface DataColumns 
		{ 
		} 

		public partial class DataColumns_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __DataColumns.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __DataColumns : java.lang.Object, DataColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static __DataColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__DataColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__DataColumns(@__env); 
				} 
			} 
			internal __DataColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__DataColumns.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class DataColumnsConstants 
		{ 
			public static java.lang.String MIMETYPE
			{ 
				get 
				{ 
					return "mimetype"; 
				} 
			} 
			public static java.lang.String RAW_CONTACT_ID
			{ 
				get 
				{ 
					return "raw_contact_id"; 
				} 
			} 
			public static java.lang.String IS_PRIMARY
			{ 
				get 
				{ 
					return "is_primary"; 
				} 
			} 
			public static java.lang.String IS_SUPER_PRIMARY
			{ 
				get 
				{ 
					return "is_super_primary"; 
				} 
			} 
			public static java.lang.String DATA_VERSION
			{ 
				get 
				{ 
					return "data_version"; 
				} 
			} 
			public static java.lang.String DATA1
			{ 
				get 
				{ 
					return "data1"; 
				} 
			} 
			public static java.lang.String DATA2
			{ 
				get 
				{ 
					return "data2"; 
				} 
			} 
			public static java.lang.String DATA3
			{ 
				get 
				{ 
					return "data3"; 
				} 
			} 
			public static java.lang.String DATA4
			{ 
				get 
				{ 
					return "data4"; 
				} 
			} 
			public static java.lang.String DATA5
			{ 
				get 
				{ 
					return "data5"; 
				} 
			} 
			public static java.lang.String DATA6
			{ 
				get 
				{ 
					return "data6"; 
				} 
			} 
			public static java.lang.String DATA7
			{ 
				get 
				{ 
					return "data7"; 
				} 
			} 
			public static java.lang.String DATA8
			{ 
				get 
				{ 
					return "data8"; 
				} 
			} 
			public static java.lang.String DATA9
			{ 
				get 
				{ 
					return "data9"; 
				} 
			} 
			public static java.lang.String DATA10
			{ 
				get 
				{ 
					return "data10"; 
				} 
			} 
			public static java.lang.String DATA11
			{ 
				get 
				{ 
					return "data11"; 
				} 
			} 
			public static java.lang.String DATA12
			{ 
				get 
				{ 
					return "data12"; 
				} 
			} 
			public static java.lang.String DATA13
			{ 
				get 
				{ 
					return "data13"; 
				} 
			} 
			public static java.lang.String DATA14
			{ 
				get 
				{ 
					return "data14"; 
				} 
			} 
			public static java.lang.String DATA15
			{ 
				get 
				{ 
					return "data15"; 
				} 
			} 
			public static java.lang.String SYNC1
			{ 
				get 
				{ 
					return "data_sync1"; 
				} 
			} 
			public static java.lang.String SYNC2
			{ 
				get 
				{ 
					return "data_sync2"; 
				} 
			} 
			public static java.lang.String SYNC3
			{ 
				get 
				{ 
					return "data_sync3"; 
				} 
			} 
			public static java.lang.String SYNC4
			{ 
				get 
				{ 
					return "data_sync4"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface DataColumnsWithJoins : BaseColumns, DataColumns, StatusColumns, RawContactsColumns, ContactsColumns, ContactOptionsColumns, ContactStatusColumns
		{ 
		} 

		public partial class DataColumnsWithJoins_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __DataColumnsWithJoins.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __DataColumnsWithJoins : java.lang.Object, DataColumnsWithJoins
		{ 
			internal static global::java.lang.Class staticClass; 
			static __DataColumnsWithJoins() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__DataColumnsWithJoins), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__DataColumnsWithJoins(@__env); 
				} 
			} 
			internal __DataColumnsWithJoins(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__DataColumnsWithJoins.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Groups : java.lang.Object, BaseColumns, GroupsColumns, SyncColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static Groups() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.Groups), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.Groups(@__env); 
				} 
			} 
			internal Groups(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6226; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_SUMMARY_URI6227; 
			public static android.net.Uri CONTENT_SUMMARY_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String CONTENT_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/group"; 
				} 
			} 
			public static java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/group"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.Groups.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface GroupsColumns 
		{ 
		} 

		public partial class GroupsColumns_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __GroupsColumns.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __GroupsColumns : java.lang.Object, GroupsColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static __GroupsColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__GroupsColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__GroupsColumns(@__env); 
				} 
			} 
			internal __GroupsColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__GroupsColumns.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class GroupsColumnsConstants 
		{ 
			public static java.lang.String TITLE
			{ 
				get 
				{ 
					return "title"; 
				} 
			} 
			public static java.lang.String NOTES
			{ 
				get 
				{ 
					return "notes"; 
				} 
			} 
			public static java.lang.String SYSTEM_ID
			{ 
				get 
				{ 
					return "system_id"; 
				} 
			} 
			public static java.lang.String SUMMARY_COUNT
			{ 
				get 
				{ 
					return "summ_count"; 
				} 
			} 
			public static java.lang.String SUMMARY_WITH_PHONES
			{ 
				get 
				{ 
					return "summ_phones"; 
				} 
			} 
			public static java.lang.String GROUP_VISIBLE
			{ 
				get 
				{ 
					return "group_visible"; 
				} 
			} 
			public static java.lang.String DELETED
			{ 
				get 
				{ 
					return "deleted"; 
				} 
			} 
			public static java.lang.String SHOULD_SYNC
			{ 
				get 
				{ 
					return "should_sync"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Intents : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Intents() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.Intents), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.Intents(@__env); 
				} 
			} 
			internal Intents(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Insert : java.lang.Object
			{ 
				internal static global::java.lang.Class staticClass; 
				static Insert() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.Intents.Insert), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.Intents.Insert(@__env); 
					} 
				} 
				internal Insert(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _Insert6228; 
				public Insert()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.provider.ContactsContract.Intents.Insert.staticClass, _Insert6228, this); 
				} 
				public static java.lang.String ACTION
				{ 
					get 
					{ 
						return "android.intent.action.INSERT"; 
					} 
				} 
				public static java.lang.String FULL_MODE
				{ 
					get 
					{ 
						return "full_mode"; 
					} 
				} 
				public static java.lang.String NAME
				{ 
					get 
					{ 
						return "name"; 
					} 
				} 
				public static java.lang.String PHONETIC_NAME
				{ 
					get 
					{ 
						return "phonetic_name"; 
					} 
				} 
				public static java.lang.String COMPANY
				{ 
					get 
					{ 
						return "company"; 
					} 
				} 
				public static java.lang.String JOB_TITLE
				{ 
					get 
					{ 
						return "job_title"; 
					} 
				} 
				public static java.lang.String NOTES
				{ 
					get 
					{ 
						return "notes"; 
					} 
				} 
				public static java.lang.String PHONE
				{ 
					get 
					{ 
						return "phone"; 
					} 
				} 
				public static java.lang.String PHONE_TYPE
				{ 
					get 
					{ 
						return "phone_type"; 
					} 
				} 
				public static java.lang.String PHONE_ISPRIMARY
				{ 
					get 
					{ 
						return "phone_isprimary"; 
					} 
				} 
				public static java.lang.String SECONDARY_PHONE
				{ 
					get 
					{ 
						return "secondary_phone"; 
					} 
				} 
				public static java.lang.String SECONDARY_PHONE_TYPE
				{ 
					get 
					{ 
						return "secondary_phone_type"; 
					} 
				} 
				public static java.lang.String TERTIARY_PHONE
				{ 
					get 
					{ 
						return "tertiary_phone"; 
					} 
				} 
				public static java.lang.String TERTIARY_PHONE_TYPE
				{ 
					get 
					{ 
						return "tertiary_phone_type"; 
					} 
				} 
				public static java.lang.String EMAIL
				{ 
					get 
					{ 
						return "email"; 
					} 
				} 
				public static java.lang.String EMAIL_TYPE
				{ 
					get 
					{ 
						return "email_type"; 
					} 
				} 
				public static java.lang.String EMAIL_ISPRIMARY
				{ 
					get 
					{ 
						return "email_isprimary"; 
					} 
				} 
				public static java.lang.String SECONDARY_EMAIL
				{ 
					get 
					{ 
						return "secondary_email"; 
					} 
				} 
				public static java.lang.String SECONDARY_EMAIL_TYPE
				{ 
					get 
					{ 
						return "secondary_email_type"; 
					} 
				} 
				public static java.lang.String TERTIARY_EMAIL
				{ 
					get 
					{ 
						return "tertiary_email"; 
					} 
				} 
				public static java.lang.String TERTIARY_EMAIL_TYPE
				{ 
					get 
					{ 
						return "tertiary_email_type"; 
					} 
				} 
				public static java.lang.String POSTAL
				{ 
					get 
					{ 
						return "postal"; 
					} 
				} 
				public static java.lang.String POSTAL_TYPE
				{ 
					get 
					{ 
						return "postal_type"; 
					} 
				} 
				public static java.lang.String POSTAL_ISPRIMARY
				{ 
					get 
					{ 
						return "postal_isprimary"; 
					} 
				} 
				public static java.lang.String IM_HANDLE
				{ 
					get 
					{ 
						return "im_handle"; 
					} 
				} 
				public static java.lang.String IM_PROTOCOL
				{ 
					get 
					{ 
						return "im_protocol"; 
					} 
				} 
				public static java.lang.String IM_ISPRIMARY
				{ 
					get 
					{ 
						return "im_isprimary"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.Intents.Insert.staticClass = @__class; 
					global::android.provider.ContactsContract.Intents.Insert._Insert6228 = @__env.GetMethodID(global::android.provider.ContactsContract.Intents.Insert.staticClass, "<init>", "()V"); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Intents6229; 
			public Intents()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.ContactsContract.Intents.staticClass, _Intents6229, this); 
			} 
			public static java.lang.String SEARCH_SUGGESTION_CLICKED
			{ 
				get 
				{ 
					return "android.provider.Contacts.SEARCH_SUGGESTION_CLICKED"; 
				} 
			} 
			public static java.lang.String SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED
			{ 
				get 
				{ 
					return "android.provider.Contacts.SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED"; 
				} 
			} 
			public static java.lang.String SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED
			{ 
				get 
				{ 
					return "android.provider.Contacts.SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED"; 
				} 
			} 
			public static java.lang.String ATTACH_IMAGE
			{ 
				get 
				{ 
					return "com.android.contacts.action.ATTACH_IMAGE"; 
				} 
			} 
			public static java.lang.String SHOW_OR_CREATE_CONTACT
			{ 
				get 
				{ 
					return "com.android.contacts.action.SHOW_OR_CREATE_CONTACT"; 
				} 
			} 
			public static java.lang.String EXTRA_FORCE_CREATE
			{ 
				get 
				{ 
					return "com.android.contacts.action.FORCE_CREATE"; 
				} 
			} 
			public static java.lang.String EXTRA_CREATE_DESCRIPTION
			{ 
				get 
				{ 
					return "com.android.contacts.action.CREATE_DESCRIPTION"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.Intents.staticClass = @__class; 
				global::android.provider.ContactsContract.Intents._Intents6229 = @__env.GetMethodID(global::android.provider.ContactsContract.Intents.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class PhoneLookup : java.lang.Object, BaseColumns, PhoneLookupColumns, ContactsColumns, ContactOptionsColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static PhoneLookup() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.PhoneLookup), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.PhoneLookup(@__env); 
				} 
			} 
			internal PhoneLookup(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_FILTER_URI6230; 
			public static android.net.Uri CONTENT_FILTER_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.PhoneLookup.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface PhoneLookupColumns 
		{ 
		} 

		public partial class PhoneLookupColumns_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __PhoneLookupColumns.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __PhoneLookupColumns : java.lang.Object, PhoneLookupColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static __PhoneLookupColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__PhoneLookupColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__PhoneLookupColumns(@__env); 
				} 
			} 
			internal __PhoneLookupColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__PhoneLookupColumns.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class PhoneLookupColumnsConstants 
		{ 
			public static java.lang.String NUMBER
			{ 
				get 
				{ 
					return "number"; 
				} 
			} 
			public static java.lang.String TYPE
			{ 
				get 
				{ 
					return "type"; 
				} 
			} 
			public static java.lang.String LABEL
			{ 
				get 
				{ 
					return "label"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Presence : android.provider.ContactsContract.StatusUpdates
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Presence() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.Presence), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.Presence(@__env); 
				} 
			} 
			internal Presence(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Presence6231; 
			public Presence()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.ContactsContract.Presence.staticClass, _Presence6231, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.Presence.staticClass = @__class; 
				global::android.provider.ContactsContract.Presence._Presence6231 = @__env.GetMethodID(global::android.provider.ContactsContract.Presence.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface PresenceColumns 
		{ 
		} 

		public partial class PresenceColumns_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __PresenceColumns.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __PresenceColumns : java.lang.Object, PresenceColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static __PresenceColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__PresenceColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__PresenceColumns(@__env); 
				} 
			} 
			internal __PresenceColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__PresenceColumns.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class PresenceColumnsConstants 
		{ 
			public static java.lang.String DATA_ID
			{ 
				get 
				{ 
					return "presence_data_id"; 
				} 
			} 
			public static java.lang.String PROTOCOL
			{ 
				get 
				{ 
					return "protocol"; 
				} 
			} 
			public static java.lang.String CUSTOM_PROTOCOL
			{ 
				get 
				{ 
					return "custom_protocol"; 
				} 
			} 
			public static java.lang.String IM_HANDLE
			{ 
				get 
				{ 
					return "im_handle"; 
				} 
			} 
			public static java.lang.String IM_ACCOUNT
			{ 
				get 
				{ 
					return "im_account"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class QuickContact : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static QuickContact() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.QuickContact), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.QuickContact(@__env); 
				} 
			} 
			internal QuickContact(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _showQuickContact6232; 
			public static void showQuickContact(android.content.Context arg0, android.view.View arg1, android.net.Uri arg2, int arg3, java.lang.String[] arg4) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.ContactsContract.QuickContact.staticClass, _showQuickContact6232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _showQuickContact6233; 
			public static void showQuickContact(android.content.Context arg0, android.graphics.Rect arg1, android.net.Uri arg2, int arg3, java.lang.String[] arg4) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.ContactsContract.QuickContact.staticClass, _showQuickContact6233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _QuickContact6234; 
			public QuickContact()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.ContactsContract.QuickContact.staticClass, _QuickContact6234, this); 
			} 
			public static int MODE_SMALL
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int MODE_MEDIUM
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
			public static int MODE_LARGE
			{ 
				get 
				{ 
					return 3; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.QuickContact.staticClass = @__class; 
				global::android.provider.ContactsContract.QuickContact._showQuickContact6232 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.QuickContact.staticClass, "showQuickContact", "(Landroid/content/Context;Landroid/view/View;Landroid/net/Uri;I[Ljava/lang/String;)V"); 
				global::android.provider.ContactsContract.QuickContact._showQuickContact6233 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.QuickContact.staticClass, "showQuickContact", "(Landroid/content/Context;Landroid/graphics/Rect;Landroid/net/Uri;I[Ljava/lang/String;)V"); 
				global::android.provider.ContactsContract.QuickContact._QuickContact6234 = @__env.GetMethodID(global::android.provider.ContactsContract.QuickContact.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class RawContacts : java.lang.Object, BaseColumns, RawContactsColumns, ContactOptionsColumns, SyncColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static RawContacts() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.RawContacts), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.RawContacts(@__env); 
				} 
			} 
			internal RawContacts(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Data : java.lang.Object, BaseColumns, DataColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Data() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.RawContacts.Data), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.RawContacts.Data(@__env); 
					} 
				} 
				internal Data(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_DIRECTORY
				{ 
					get 
					{ 
						return "data"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.RawContacts.Data.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Entity : java.lang.Object, BaseColumns, DataColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Entity() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.RawContacts.Entity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.ContactsContract.RawContacts.Entity(@__env); 
					} 
				} 
				internal Entity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_DIRECTORY
				{ 
					get 
					{ 
						return "entity"; 
					} 
				} 
				public static java.lang.String DATA_ID
				{ 
					get 
					{ 
						return "data_id"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.ContactsContract.RawContacts.Entity.staticClass = @__class; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getContactLookupUri6235; 
			public static android.net.Uri getContactLookupUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.RawContacts.staticClass, _getContactLookupUri6235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6236; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String CONTENT_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/raw_contact"; 
				} 
			} 
			public static java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/raw_contact"; 
				} 
			} 
			public static int AGGREGATION_MODE_DEFAULT
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int AGGREGATION_MODE_IMMEDIATE
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int AGGREGATION_MODE_SUSPENDED
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
			public static int AGGREGATION_MODE_DISABLED
			{ 
				get 
				{ 
					return 3; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.RawContacts.staticClass = @__class; 
				global::android.provider.ContactsContract.RawContacts._getContactLookupUri6235 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.RawContacts.staticClass, "getContactLookupUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/net/Uri;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface RawContactsColumns 
		{ 
		} 

		public partial class RawContactsColumns_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __RawContactsColumns.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __RawContactsColumns : java.lang.Object, RawContactsColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static __RawContactsColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__RawContactsColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__RawContactsColumns(@__env); 
				} 
			} 
			internal __RawContactsColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__RawContactsColumns.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class RawContactsColumnsConstants 
		{ 
			public static java.lang.String CONTACT_ID
			{ 
				get 
				{ 
					return "contact_id"; 
				} 
			} 
			public static java.lang.String AGGREGATION_MODE
			{ 
				get 
				{ 
					return "aggregation_mode"; 
				} 
			} 
			public static java.lang.String DELETED
			{ 
				get 
				{ 
					return "deleted"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class RawContactsEntity : java.lang.Object, BaseColumns, DataColumns, RawContactsColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static RawContactsEntity() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.RawContactsEntity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.RawContactsEntity(@__env); 
				} 
			} 
			internal RawContactsEntity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6237; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String CONTENT_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/raw_contact_entity"; 
				} 
			} 
			public static java.lang.String DATA_ID
			{ 
				get 
				{ 
					return "data_id"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.RawContactsEntity.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Settings : java.lang.Object, SettingsColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static Settings() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.Settings), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.Settings(@__env); 
				} 
			} 
			internal Settings(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6238; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String CONTENT_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/setting"; 
				} 
			} 
			public static java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/setting"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.Settings.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface SettingsColumns 
		{ 
		} 

		public partial class SettingsColumns_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __SettingsColumns.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __SettingsColumns : java.lang.Object, SettingsColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static __SettingsColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__SettingsColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__SettingsColumns(@__env); 
				} 
			} 
			internal __SettingsColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__SettingsColumns.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class SettingsColumnsConstants 
		{ 
			public static java.lang.String ACCOUNT_NAME
			{ 
				get 
				{ 
					return "account_name"; 
				} 
			} 
			public static java.lang.String ACCOUNT_TYPE
			{ 
				get 
				{ 
					return "account_type"; 
				} 
			} 
			public static java.lang.String SHOULD_SYNC
			{ 
				get 
				{ 
					return "should_sync"; 
				} 
			} 
			public static java.lang.String UNGROUPED_VISIBLE
			{ 
				get 
				{ 
					return "ungrouped_visible"; 
				} 
			} 
			public static java.lang.String ANY_UNSYNCED
			{ 
				get 
				{ 
					return "any_unsynced"; 
				} 
			} 
			public static java.lang.String UNGROUPED_COUNT
			{ 
				get 
				{ 
					return "summ_count"; 
				} 
			} 
			public static java.lang.String UNGROUPED_WITH_PHONES
			{ 
				get 
				{ 
					return "summ_phones"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface StatusColumns 
		{ 
		} 

		public partial class StatusColumns_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __StatusColumns.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __StatusColumns : java.lang.Object, StatusColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static __StatusColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__StatusColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__StatusColumns(@__env); 
				} 
			} 
			internal __StatusColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__StatusColumns.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class StatusColumnsConstants 
		{ 
			public static java.lang.String PRESENCE
			{ 
				get 
				{ 
					return "mode"; 
				} 
			} 
			public static java.lang.String STATUS
			{ 
				get 
				{ 
					return "status"; 
				} 
			} 
			public static java.lang.String STATUS_TIMESTAMP
			{ 
				get 
				{ 
					return "status_ts"; 
				} 
			} 
			public static java.lang.String STATUS_RES_PACKAGE
			{ 
				get 
				{ 
					return "status_res_package"; 
				} 
			} 
			public static java.lang.String STATUS_LABEL
			{ 
				get 
				{ 
					return "status_label"; 
				} 
			} 
			public static java.lang.String STATUS_ICON
			{ 
				get 
				{ 
					return "status_icon"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class StatusUpdates : java.lang.Object, StatusColumns, PresenceColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static StatusUpdates() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.StatusUpdates), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.StatusUpdates(@__env); 
				} 
			} 
			protected StatusUpdates(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getPresenceIconResourceId6239; 
			public static int getPresenceIconResourceId(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.provider.ContactsContract.StatusUpdates.staticClass, _getPresenceIconResourceId6239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getPresencePrecedence6240; 
			public static int getPresencePrecedence(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.provider.ContactsContract.StatusUpdates.staticClass, _getPresencePrecedence6240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6241; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String CONTENT_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/status-update"; 
				} 
			} 
			public static java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/status-update"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.StatusUpdates.staticClass = @__class; 
				global::android.provider.ContactsContract.StatusUpdates._getPresenceIconResourceId6239 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.StatusUpdates.staticClass, "getPresenceIconResourceId", "(I)I"); 
				global::android.provider.ContactsContract.StatusUpdates._getPresencePrecedence6240 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.StatusUpdates.staticClass, "getPresencePrecedence", "(I)I"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		protected interface SyncColumns : BaseSyncColumns
		{ 
		} 

		public partial class SyncColumns_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __SyncColumns.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class __SyncColumns : java.lang.Object, SyncColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static __SyncColumns() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.__SyncColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.__SyncColumns(@__env); 
				} 
			} 
			internal __SyncColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.__SyncColumns.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class SyncColumnsConstants 
		{ 
			public static java.lang.String ACCOUNT_NAME
			{ 
				get 
				{ 
					return "account_name"; 
				} 
			} 
			public static java.lang.String ACCOUNT_TYPE
			{ 
				get 
				{ 
					return "account_type"; 
				} 
			} 
			public static java.lang.String SOURCE_ID
			{ 
				get 
				{ 
					return "sourceid"; 
				} 
			} 
			public static java.lang.String VERSION
			{ 
				get 
				{ 
					return "version"; 
				} 
			} 
			public static java.lang.String DIRTY
			{ 
				get 
				{ 
					return "dirty"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class SyncState : java.lang.Object, android.provider.SyncStateContract.Columns
		{ 
			internal static global::java.lang.Class staticClass; 
			static SyncState() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.ContactsContract.SyncState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.ContactsContract.SyncState(@__env); 
				} 
			} 
			internal SyncState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _get6242; 
			public static byte[] get(android.content.ContentProviderClient arg0, android.accounts.Account arg1) 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.SyncState.staticClass, _get6242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _set6243; 
			public static void set(android.content.ContentProviderClient arg0, android.accounts.Account arg1, byte[] arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.ContactsContract.SyncState.staticClass, _set6243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getWithUri6244; 
			public static android.util.Pair getWithUri(android.content.ContentProviderClient arg0, android.accounts.Account arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.Pair>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.SyncState.staticClass, _getWithUri6244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _newSetOperation6245; 
			public static android.content.ContentProviderOperation newSetOperation(android.accounts.Account arg0, byte[] arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.ContactsContract.SyncState.staticClass, _newSetOperation6245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			} 
			public static java.lang.String CONTENT_DIRECTORY
			{ 
				get 
				{ 
					return "syncstate"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6246; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.ContactsContract.SyncState.staticClass = @__class; 
				global::android.provider.ContactsContract.SyncState._get6242 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.SyncState.staticClass, "get", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)[B"); 
				global::android.provider.ContactsContract.SyncState._set6243 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.SyncState.staticClass, "set", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;[B)V"); 
				global::android.provider.ContactsContract.SyncState._getWithUri6244 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.SyncState.staticClass, "getWithUri", "(Landroid/content/ContentProviderClient;Landroid/accounts/Account;)Landroid/util/Pair;"); 
				global::android.provider.ContactsContract.SyncState._newSetOperation6245 = @__env.GetStaticMethodID(global::android.provider.ContactsContract.SyncState.staticClass, "newSetOperation", "(Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContactsContract6247; 
		public ContactsContract()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.provider.ContactsContract.staticClass, _ContactsContract6247, this); 
		} 
		public static java.lang.String AUTHORITY
		{ 
			get 
			{ 
				return "com.android.contacts"; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _AUTHORITY_URI6248; 
		public static android.net.Uri AUTHORITY_URI
		{ 
			get 
			{ 
				return default(android.net.Uri); 
			} 
		} 
		public static java.lang.String CALLER_IS_SYNCADAPTER
		{ 
			get 
			{ 
				return "caller_is_syncadapter"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.provider.ContactsContract.staticClass = @__class; 
			global::android.provider.ContactsContract._ContactsContract6247 = @__env.GetMethodID(global::android.provider.ContactsContract.staticClass, "<init>", "()V"); 
		} 
	} 
} 
