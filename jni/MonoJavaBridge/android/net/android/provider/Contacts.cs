namespace android.provider 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Contacts : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Contacts() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.provider.Contacts(@__env); 
			} 
		} 
		protected Contacts(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class ContactMethods : java.lang.Object, BaseColumns, ContactMethodsColumns, PeopleColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static ContactMethods() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.ContactMethods), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Contacts.ContactMethods(@__env); 
				} 
			} 
			internal ContactMethods(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getDisplayLabel5875; 
			public static java.lang.CharSequence getDisplayLabel(android.content.Context arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.ContactMethods.staticClass, _getDisplayLabel5875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _encodePredefinedImProtocol5876; 
			public static java.lang.String encodePredefinedImProtocol(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.ContactMethods.staticClass, _encodePredefinedImProtocol5876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _encodeCustomImProtocol5877; 
			public static java.lang.String encodeCustomImProtocol(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.ContactMethods.staticClass, _encodeCustomImProtocol5877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _decodeImProtocol5878; 
			public static java.lang.Object decodeImProtocol(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.ContactMethods.staticClass, _decodeImProtocol5878, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _addPostalLocation5879; 
			public void addPostalLocation(android.content.Context arg0, long arg1, double arg2, double arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.provider.Contacts.ContactMethods)) 
					@__env.CallVoidMethod(this, _addPostalLocation5879, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.provider.Contacts.ContactMethods.staticClass, _addPostalLocation5879, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			public static java.lang.String POSTAL_LOCATION_LATITUDE
			{ 
				get 
				{ 
					return "data"; 
				} 
			} 
			public static java.lang.String POSTAL_LOCATION_LONGITUDE
			{ 
				get 
				{ 
					return "aux_data"; 
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
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI5880; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_EMAIL_URI5881; 
			public static android.net.Uri CONTENT_EMAIL_URI
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
					return "vnd.android.cursor.dir/contact-methods"; 
				} 
			} 
			public static java.lang.String CONTENT_EMAIL_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/email"; 
				} 
			} 
			public static java.lang.String CONTENT_POSTAL_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/postal-address"; 
				} 
			} 
			public static java.lang.String CONTENT_EMAIL_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/email"; 
				} 
			} 
			public static java.lang.String CONTENT_POSTAL_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/postal-address"; 
				} 
			} 
			public static java.lang.String CONTENT_IM_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/jabber-im"; 
				} 
			} 
			public static java.lang.String DEFAULT_SORT_ORDER
			{ 
				get 
				{ 
					return "name ASC"; 
				} 
			} 
			public static java.lang.String PERSON_ID
			{ 
				get 
				{ 
					return "person"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Contacts.ContactMethods.staticClass = @__class; 
				global::android.provider.Contacts.ContactMethods._getDisplayLabel5875 = @__env.GetStaticMethodID(global::android.provider.Contacts.ContactMethods.staticClass, "getDisplayLabel", "(Landroid/content/Context;IILjava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
				global::android.provider.Contacts.ContactMethods._encodePredefinedImProtocol5876 = @__env.GetStaticMethodID(global::android.provider.Contacts.ContactMethods.staticClass, "encodePredefinedImProtocol", "(I)Ljava/lang/String;"); 
				global::android.provider.Contacts.ContactMethods._encodeCustomImProtocol5877 = @__env.GetStaticMethodID(global::android.provider.Contacts.ContactMethods.staticClass, "encodeCustomImProtocol", "(Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.provider.Contacts.ContactMethods._decodeImProtocol5878 = @__env.GetStaticMethodID(global::android.provider.Contacts.ContactMethods.staticClass, "decodeImProtocol", "(Ljava/lang/String;)Ljava/lang/Object;"); 
				global::android.provider.Contacts.ContactMethods._addPostalLocation5879 = @__env.GetMethodID(global::android.provider.Contacts.ContactMethods.staticClass, "addPostalLocation", "(Landroid/content/Context;JDD)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface ContactMethodsColumns 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class ContactMethodsColumnsConstants 
		{ 
			public static java.lang.String KIND
			{ 
				get 
				{ 
					return "kind"; 
				} 
			} 
			public static java.lang.String TYPE
			{ 
				get 
				{ 
					return "type"; 
				} 
			} 
			public static int TYPE_CUSTOM
			{ 
				get 
				{ 
					return 0; 
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
			public static java.lang.String LABEL
			{ 
				get 
				{ 
					return "label"; 
				} 
			} 
			public static java.lang.String DATA
			{ 
				get 
				{ 
					return "data"; 
				} 
			} 
			public static java.lang.String AUX_DATA
			{ 
				get 
				{ 
					return "aux_data"; 
				} 
			} 
			public static java.lang.String ISPRIMARY
			{ 
				get 
				{ 
					return "isprimary"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Extensions : java.lang.Object, BaseColumns, ExtensionsColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static Extensions() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.Extensions), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Contacts.Extensions(@__env); 
				} 
			} 
			internal Extensions(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI5882; 
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
					return "vnd.android.cursor.dir/contact_extensions"; 
				} 
			} 
			public static java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/contact_extensions"; 
				} 
			} 
			public static java.lang.String DEFAULT_SORT_ORDER
			{ 
				get 
				{ 
					return "person, name ASC"; 
				} 
			} 
			public static java.lang.String PERSON_ID
			{ 
				get 
				{ 
					return "person"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Contacts.Extensions.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface ExtensionsColumns 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class ExtensionsColumnsConstants 
		{ 
			public static java.lang.String NAME
			{ 
				get 
				{ 
					return "name"; 
				} 
			} 
			public static java.lang.String VALUE
			{ 
				get 
				{ 
					return "value"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class GroupMembership : java.lang.Object, BaseColumns, GroupsColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static GroupMembership() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.GroupMembership), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Contacts.GroupMembership(@__env); 
				} 
			} 
			internal GroupMembership(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI5883; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RAW_CONTENT_URI5884; 
			public static android.net.Uri RAW_CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String CONTENT_DIRECTORY
			{ 
				get 
				{ 
					return "groupmembership"; 
				} 
			} 
			public static java.lang.String CONTENT_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.dir/contactsgroupmembership"; 
				} 
			} 
			public static java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/contactsgroupmembership"; 
				} 
			} 
			public static java.lang.String DEFAULT_SORT_ORDER
			{ 
				get 
				{ 
					return "group_id ASC"; 
				} 
			} 
			public static java.lang.String GROUP_ID
			{ 
				get 
				{ 
					return "group_id"; 
				} 
			} 
			public static java.lang.String GROUP_SYNC_ID
			{ 
				get 
				{ 
					return "group_sync_id"; 
				} 
			} 
			public static java.lang.String GROUP_SYNC_ACCOUNT
			{ 
				get 
				{ 
					return "group_sync_account"; 
				} 
			} 
			public static java.lang.String GROUP_SYNC_ACCOUNT_TYPE
			{ 
				get 
				{ 
					return "group_sync_account_type"; 
				} 
			} 
			public static java.lang.String PERSON_ID
			{ 
				get 
				{ 
					return "person"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Contacts.GroupMembership.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Groups : java.lang.Object, BaseColumns, GroupsColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static Groups() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.Groups), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Contacts.Groups(@__env); 
				} 
			} 
			internal Groups(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI5885; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DELETED_CONTENT_URI5886; 
			public static android.net.Uri DELETED_CONTENT_URI
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
					return "vnd.android.cursor.dir/contactsgroup"; 
				} 
			} 
			public static java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/contactsgroup"; 
				} 
			} 
			public static java.lang.String DEFAULT_SORT_ORDER
			{ 
				get 
				{ 
					return "name ASC"; 
				} 
			} 
			public static java.lang.String GROUP_ANDROID_STARRED
			{ 
				get 
				{ 
					return "Starred in Android"; 
				} 
			} 
			public static java.lang.String GROUP_MY_CONTACTS
			{ 
				get 
				{ 
					return "Contacts"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Contacts.Groups.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface GroupsColumns 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class GroupsColumnsConstants 
		{ 
			public static java.lang.String NAME
			{ 
				get 
				{ 
					return "name"; 
				} 
			} 
			public static java.lang.String NOTES
			{ 
				get 
				{ 
					return "notes"; 
				} 
			} 
			public static java.lang.String SHOULD_SYNC
			{ 
				get 
				{ 
					return "should_sync"; 
				} 
			} 
			public static java.lang.String SYSTEM_ID
			{ 
				get 
				{ 
					return "system_id"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Intents : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Intents() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.Intents), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Contacts.Intents(@__env); 
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
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.Intents.Insert), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.Contacts.Intents.Insert(@__env); 
					} 
				} 
				internal Insert(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _Insert5887; 
				public Insert()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.provider.Contacts.Intents.Insert.staticClass, _Insert5887, this); 
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
					global::android.provider.Contacts.Intents.Insert.staticClass = @__class; 
					global::android.provider.Contacts.Intents.Insert._Insert5887 = @__env.GetMethodID(global::android.provider.Contacts.Intents.Insert.staticClass, "<init>", "()V"); 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class UI : java.lang.Object
			{ 
				internal static global::java.lang.Class staticClass; 
				static UI() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.Intents.UI), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.Contacts.Intents.UI(@__env); 
					} 
				} 
				internal UI(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _UI5888; 
				public UI()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.provider.Contacts.Intents.UI.staticClass, _UI5888, this); 
				} 
				public static java.lang.String LIST_DEFAULT
				{ 
					get 
					{ 
						return "com.android.contacts.action.LIST_DEFAULT"; 
					} 
				} 
				public static java.lang.String LIST_GROUP_ACTION
				{ 
					get 
					{ 
						return "com.android.contacts.action.LIST_GROUP"; 
					} 
				} 
				public static java.lang.String GROUP_NAME_EXTRA_KEY
				{ 
					get 
					{ 
						return "com.android.contacts.extra.GROUP"; 
					} 
				} 
				public static java.lang.String LIST_ALL_CONTACTS_ACTION
				{ 
					get 
					{ 
						return "com.android.contacts.action.LIST_ALL_CONTACTS"; 
					} 
				} 
				public static java.lang.String LIST_CONTACTS_WITH_PHONES_ACTION
				{ 
					get 
					{ 
						return "com.android.contacts.action.LIST_CONTACTS_WITH_PHONES"; 
					} 
				} 
				public static java.lang.String LIST_STARRED_ACTION
				{ 
					get 
					{ 
						return "com.android.contacts.action.LIST_STARRED"; 
					} 
				} 
				public static java.lang.String LIST_FREQUENT_ACTION
				{ 
					get 
					{ 
						return "com.android.contacts.action.LIST_FREQUENT"; 
					} 
				} 
				public static java.lang.String LIST_STREQUENT_ACTION
				{ 
					get 
					{ 
						return "com.android.contacts.action.LIST_STREQUENT"; 
					} 
				} 
				public static java.lang.String TITLE_EXTRA_KEY
				{ 
					get 
					{ 
						return "com.android.contacts.extra.TITLE_EXTRA"; 
					} 
				} 
				public static java.lang.String FILTER_CONTACTS_ACTION
				{ 
					get 
					{ 
						return "com.android.contacts.action.FILTER_CONTACTS"; 
					} 
				} 
				public static java.lang.String FILTER_TEXT_EXTRA_KEY
				{ 
					get 
					{ 
						return "com.android.contacts.extra.FILTER_TEXT"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.Contacts.Intents.UI.staticClass = @__class; 
					global::android.provider.Contacts.Intents.UI._UI5888 = @__env.GetMethodID(global::android.provider.Contacts.Intents.UI.staticClass, "<init>", "()V"); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Intents5889; 
			public Intents()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.Contacts.Intents.staticClass, _Intents5889, this); 
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
				global::android.provider.Contacts.Intents.staticClass = @__class; 
				global::android.provider.Contacts.Intents._Intents5889 = @__env.GetMethodID(global::android.provider.Contacts.Intents.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OrganizationColumns 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class OrganizationColumnsConstants 
		{ 
			public static java.lang.String TYPE
			{ 
				get 
				{ 
					return "type"; 
				} 
			} 
			public static int TYPE_CUSTOM
			{ 
				get 
				{ 
					return 0; 
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
			public static java.lang.String LABEL
			{ 
				get 
				{ 
					return "label"; 
				} 
			} 
			public static java.lang.String COMPANY
			{ 
				get 
				{ 
					return "company"; 
				} 
			} 
			public static java.lang.String TITLE
			{ 
				get 
				{ 
					return "title"; 
				} 
			} 
			public static java.lang.String PERSON_ID
			{ 
				get 
				{ 
					return "person"; 
				} 
			} 
			public static java.lang.String ISPRIMARY
			{ 
				get 
				{ 
					return "isprimary"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Organizations : java.lang.Object, BaseColumns, OrganizationColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static Organizations() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.Organizations), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Contacts.Organizations(@__env); 
				} 
			} 
			internal Organizations(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getDisplayLabel5890; 
			public static java.lang.CharSequence getDisplayLabel(android.content.Context arg0, int arg1, java.lang.CharSequence arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.Organizations.staticClass, _getDisplayLabel5890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI5891; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String CONTENT_DIRECTORY
			{ 
				get 
				{ 
					return "organizations"; 
				} 
			} 
			public static java.lang.String DEFAULT_SORT_ORDER
			{ 
				get 
				{ 
					return "company, title, isprimary ASC"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Contacts.Organizations.staticClass = @__class; 
				global::android.provider.Contacts.Organizations._getDisplayLabel5890 = @__env.GetStaticMethodID(global::android.provider.Contacts.Organizations.staticClass, "getDisplayLabel", "(Landroid/content/Context;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class People : java.lang.Object, BaseColumns, PeopleColumns, PhonesColumns, PresenceColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static People() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.People), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Contacts.People(@__env); 
				} 
			} 
			internal People(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class ContactMethods : java.lang.Object, BaseColumns, ContactMethodsColumns, PeopleColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static ContactMethods() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.People.ContactMethods), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.Contacts.People.ContactMethods(@__env); 
					} 
				} 
				internal ContactMethods(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_DIRECTORY
				{ 
					get 
					{ 
						return "contact_methods"; 
					} 
				} 
				public static java.lang.String DEFAULT_SORT_ORDER
				{ 
					get 
					{ 
						return "data ASC"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.Contacts.People.ContactMethods.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public class Extensions : java.lang.Object, BaseColumns, ExtensionsColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Extensions() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.People.Extensions), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.Contacts.People.Extensions(@__env); 
					} 
				} 
				protected Extensions(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_DIRECTORY
				{ 
					get 
					{ 
						return "extensions"; 
					} 
				} 
				public static java.lang.String DEFAULT_SORT_ORDER
				{ 
					get 
					{ 
						return "name ASC"; 
					} 
				} 
				public static java.lang.String PERSON_ID
				{ 
					get 
					{ 
						return "person"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.Contacts.People.Extensions.staticClass = @__class; 
				} 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public sealed class Phones : java.lang.Object, BaseColumns, PhonesColumns, PeopleColumns
			{ 
				internal static global::java.lang.Class staticClass; 
				static Phones() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.People.Phones), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.provider.Contacts.People.Phones(@__env); 
					} 
				} 
				internal Phones(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				public static java.lang.String CONTENT_DIRECTORY
				{ 
					get 
					{ 
						return "phones"; 
					} 
				} 
				public static java.lang.String DEFAULT_SORT_ORDER
				{ 
					get 
					{ 
						return "number ASC"; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.provider.Contacts.People.Phones.staticClass = @__class; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _markAsContacted5892; 
			public static void markAsContacted(android.content.ContentResolver arg0, long arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.Contacts.People.staticClass, _markAsContacted5892, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _addToMyContactsGroup5893; 
			public static android.net.Uri addToMyContactsGroup(android.content.ContentResolver arg0, long arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.People.staticClass, _addToMyContactsGroup5893, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _addToGroup5894; 
			public static android.net.Uri addToGroup(android.content.ContentResolver arg0, long arg1, java.lang.String arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.People.staticClass, _addToGroup5894, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _addToGroup5895; 
			public static android.net.Uri addToGroup(android.content.ContentResolver arg0, long arg1, long arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.People.staticClass, _addToGroup5895, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _createPersonInMyContactsGroup5896; 
			public static android.net.Uri createPersonInMyContactsGroup(android.content.ContentResolver arg0, android.content.ContentValues arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.People.staticClass, _createPersonInMyContactsGroup5896, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _queryGroups5897; 
			public static android.database.Cursor queryGroups(android.content.ContentResolver arg0, long arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.People.staticClass, _queryGroups5897, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setPhotoData5898; 
			public static void setPhotoData(android.content.ContentResolver arg0, android.net.Uri arg1, byte[] arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.Contacts.People.staticClass, _setPhotoData5898, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _openContactPhotoInputStream5899; 
			public static java.io.InputStream openContactPhotoInputStream(android.content.ContentResolver arg0, android.net.Uri arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.People.staticClass, _openContactPhotoInputStream5899, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _loadContactPhoto5900; 
			public static android.graphics.Bitmap loadContactPhoto(android.content.Context arg0, android.net.Uri arg1, int arg2, android.graphics.BitmapFactory.Options arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.People.staticClass, _loadContactPhoto5900, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI5901; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_FILTER_URI5902; 
			public static android.net.Uri CONTENT_FILTER_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DELETED_CONTENT_URI5903; 
			public static android.net.Uri DELETED_CONTENT_URI
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
					return "vnd.android.cursor.dir/person"; 
				} 
			} 
			public static java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/person"; 
				} 
			} 
			public static java.lang.String DEFAULT_SORT_ORDER
			{ 
				get 
				{ 
					return "name ASC"; 
				} 
			} 
			public static java.lang.String PRIMARY_PHONE_ID
			{ 
				get 
				{ 
					return "primary_phone"; 
				} 
			} 
			public static java.lang.String PRIMARY_EMAIL_ID
			{ 
				get 
				{ 
					return "primary_email"; 
				} 
			} 
			public static java.lang.String PRIMARY_ORGANIZATION_ID
			{ 
				get 
				{ 
					return "primary_organization"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Contacts.People.staticClass = @__class; 
				global::android.provider.Contacts.People._markAsContacted5892 = @__env.GetStaticMethodID(global::android.provider.Contacts.People.staticClass, "markAsContacted", "(Landroid/content/ContentResolver;J)V"); 
				global::android.provider.Contacts.People._addToMyContactsGroup5893 = @__env.GetStaticMethodID(global::android.provider.Contacts.People.staticClass, "addToMyContactsGroup", "(Landroid/content/ContentResolver;J)Landroid/net/Uri;"); 
				global::android.provider.Contacts.People._addToGroup5894 = @__env.GetStaticMethodID(global::android.provider.Contacts.People.staticClass, "addToGroup", "(Landroid/content/ContentResolver;JLjava/lang/String;)Landroid/net/Uri;"); 
				global::android.provider.Contacts.People._addToGroup5895 = @__env.GetStaticMethodID(global::android.provider.Contacts.People.staticClass, "addToGroup", "(Landroid/content/ContentResolver;JJ)Landroid/net/Uri;"); 
				global::android.provider.Contacts.People._createPersonInMyContactsGroup5896 = @__env.GetStaticMethodID(global::android.provider.Contacts.People.staticClass, "createPersonInMyContactsGroup", "(Landroid/content/ContentResolver;Landroid/content/ContentValues;)Landroid/net/Uri;"); 
				global::android.provider.Contacts.People._queryGroups5897 = @__env.GetStaticMethodID(global::android.provider.Contacts.People.staticClass, "queryGroups", "(Landroid/content/ContentResolver;J)Landroid/database/Cursor;"); 
				global::android.provider.Contacts.People._setPhotoData5898 = @__env.GetStaticMethodID(global::android.provider.Contacts.People.staticClass, "setPhotoData", "(Landroid/content/ContentResolver;Landroid/net/Uri;[B)V"); 
				global::android.provider.Contacts.People._openContactPhotoInputStream5899 = @__env.GetStaticMethodID(global::android.provider.Contacts.People.staticClass, "openContactPhotoInputStream", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Ljava/io/InputStream;"); 
				global::android.provider.Contacts.People._loadContactPhoto5900 = @__env.GetStaticMethodID(global::android.provider.Contacts.People.staticClass, "loadContactPhoto", "(Landroid/content/Context;Landroid/net/Uri;ILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface PeopleColumns 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class PeopleColumnsConstants 
		{ 
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
			public static java.lang.String DISPLAY_NAME
			{ 
				get 
				{ 
					return "display_name"; 
				} 
			} 
			public static java.lang.String NOTES
			{ 
				get 
				{ 
					return "notes"; 
				} 
			} 
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
			public static java.lang.String STARRED
			{ 
				get 
				{ 
					return "starred"; 
				} 
			} 
			public static java.lang.String PHOTO_VERSION
			{ 
				get 
				{ 
					return "photo_version"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Phones : java.lang.Object, BaseColumns, PhonesColumns, PeopleColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static Phones() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.Phones), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Contacts.Phones(@__env); 
				} 
			} 
			internal Phones(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getDisplayLabel5904; 
			public static java.lang.CharSequence getDisplayLabel(android.content.Context arg0, int arg1, java.lang.CharSequence arg2, java.lang.CharSequence[] arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.Phones.staticClass, _getDisplayLabel5904, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg3))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getDisplayLabel5905; 
			public static java.lang.CharSequence getDisplayLabel(android.content.Context arg0, int arg1, java.lang.CharSequence arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.Phones.staticClass, _getDisplayLabel5905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI5906; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_FILTER_URL5907; 
			public static android.net.Uri CONTENT_FILTER_URL
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
					return "vnd.android.cursor.dir/phone"; 
				} 
			} 
			public static java.lang.String CONTENT_ITEM_TYPE
			{ 
				get 
				{ 
					return "vnd.android.cursor.item/phone"; 
				} 
			} 
			public static java.lang.String DEFAULT_SORT_ORDER
			{ 
				get 
				{ 
					return "name ASC"; 
				} 
			} 
			public static java.lang.String PERSON_ID
			{ 
				get 
				{ 
					return "person"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Contacts.Phones.staticClass = @__class; 
				global::android.provider.Contacts.Phones._getDisplayLabel5904 = @__env.GetStaticMethodID(global::android.provider.Contacts.Phones.staticClass, "getDisplayLabel", "(Landroid/content/Context;ILjava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
				global::android.provider.Contacts.Phones._getDisplayLabel5905 = @__env.GetStaticMethodID(global::android.provider.Contacts.Phones.staticClass, "getDisplayLabel", "(Landroid/content/Context;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface PhonesColumns 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class PhonesColumnsConstants 
		{ 
			public static java.lang.String TYPE
			{ 
				get 
				{ 
					return "type"; 
				} 
			} 
			public static int TYPE_CUSTOM
			{ 
				get 
				{ 
					return 0; 
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
			public static java.lang.String LABEL
			{ 
				get 
				{ 
					return "label"; 
				} 
			} 
			public static java.lang.String NUMBER
			{ 
				get 
				{ 
					return "number"; 
				} 
			} 
			public static java.lang.String NUMBER_KEY
			{ 
				get 
				{ 
					return "number_key"; 
				} 
			} 
			public static java.lang.String ISPRIMARY
			{ 
				get 
				{ 
					return "isprimary"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Photos : java.lang.Object, BaseColumns, PhotosColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static Photos() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.Photos), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Contacts.Photos(@__env); 
				} 
			} 
			internal Photos(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI5908; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String CONTENT_DIRECTORY
			{ 
				get 
				{ 
					return "photo"; 
				} 
			} 
			public static java.lang.String DEFAULT_SORT_ORDER
			{ 
				get 
				{ 
					return "person ASC"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Contacts.Photos.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface PhotosColumns 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class PhotosColumnsConstants 
		{ 
			public static java.lang.String LOCAL_VERSION
			{ 
				get 
				{ 
					return "local_version"; 
				} 
			} 
			public static java.lang.String PERSON_ID
			{ 
				get 
				{ 
					return "person"; 
				} 
			} 
			public static java.lang.String DOWNLOAD_REQUIRED
			{ 
				get 
				{ 
					return "download_required"; 
				} 
			} 
			public static java.lang.String EXISTS_ON_SERVER
			{ 
				get 
				{ 
					return "exists_on_server"; 
				} 
			} 
			public static java.lang.String SYNC_ERROR
			{ 
				get 
				{ 
					return "sync_error"; 
				} 
			} 
			public static java.lang.String DATA
			{ 
				get 
				{ 
					return "data"; 
				} 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface PresenceColumns 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class PresenceColumnsConstants 
		{ 
			public static java.lang.String IM_PROTOCOL
			{ 
				get 
				{ 
					return "im_protocol"; 
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
		public sealed class Settings : java.lang.Object, BaseColumns, SettingsColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static Settings() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Contacts.Settings), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Contacts.Settings(@__env); 
				} 
			} 
			internal Settings(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSetting5909; 
			public static java.lang.String getSetting(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Contacts.Settings.staticClass, _getSetting5909, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setSetting5910; 
			public static void setSetting(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.Contacts.Settings.staticClass, _setSetting5910, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI5911; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String CONTENT_DIRECTORY
			{ 
				get 
				{ 
					return "settings"; 
				} 
			} 
			public static java.lang.String DEFAULT_SORT_ORDER
			{ 
				get 
				{ 
					return "key ASC"; 
				} 
			} 
			public static java.lang.String SYNC_EVERYTHING
			{ 
				get 
				{ 
					return "syncEverything"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Contacts.Settings.staticClass = @__class; 
				global::android.provider.Contacts.Settings._getSetting5909 = @__env.GetStaticMethodID(global::android.provider.Contacts.Settings.staticClass, "getSetting", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.provider.Contacts.Settings._setSetting5910 = @__env.GetStaticMethodID(global::android.provider.Contacts.Settings.staticClass, "setSetting", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface SettingsColumns 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class SettingsColumnsConstants 
		{ 
			public static java.lang.String _SYNC_ACCOUNT
			{ 
				get 
				{ 
					return "_sync_account"; 
				} 
			} 
			public static java.lang.String _SYNC_ACCOUNT_TYPE
			{ 
				get 
				{ 
					return "_sync_account_type"; 
				} 
			} 
			public static java.lang.String KEY
			{ 
				get 
				{ 
					return "key"; 
				} 
			} 
			public static java.lang.String VALUE
			{ 
				get 
				{ 
					return "value"; 
				} 
			} 
		} 
		public static java.lang.String AUTHORITY
		{ 
			get 
			{ 
				return "contacts"; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI5912; 
		public static android.net.Uri CONTENT_URI
		{ 
			get 
			{ 
				return default(android.net.Uri); 
			} 
		} 
		public static int KIND_EMAIL
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int KIND_POSTAL
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int KIND_IM
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int KIND_ORGANIZATION
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int KIND_PHONE
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.provider.Contacts.staticClass = @__class; 
		} 
	} 
} 
